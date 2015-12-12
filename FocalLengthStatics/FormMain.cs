using FolderSelect;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocalLengthStatics
{
    public partial class FormMain : Form
    {
        public string CSVFilePath { get; set; }

        public int ProgressPercentage
        {
            set
            {
                if (this.InvokeRequired)
                {
                    progressBar.BeginInvoke((MethodInvoker)delegate () { progressBar.Value = value; });
                }
                else
                {
                    progressBar.Value = value;
                }
            }
        }

        public FormMain()
        {
            InitializeComponent();
            Core.FormMain = this;

            textBoxSearchDirectory.Text = @"F:\Pictures\";
            textBoxCSVFile.Text = @"statics.db";
            Core.Config.ExclusionFiles = new List<string>() { ".Picasa3Temp" }; //隠しオプション
            dateTimePickerEnd.Value = DateTime.Now; //表示範囲　年月
        }

        /// <summary>
        /// データベースの作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonCreateCSV_Click(object sender, EventArgs e)
        {
            groupBoxCreateHeatmap.Enabled = groupBox2.Enabled = groupBox3.Enabled = false;

            progressBar.Value = 0;
            SetConfig(); //パラメータを取得

            await Task.Run(() =>
            {
                var sqlite = new StaticsSQLite();
                sqlite.Create();
            });

            groupBox2.Enabled = groupBox3.Enabled = true;
        }

        private void SetConfig()
        {
            Core.Config.SearchDirectoryPath = textBoxSearchDirectory.Text;
            Core.Config.SQLiteOutputPath = textBoxCSVFile.Text;

            var checkboxes = new[] { checkBox1, checkBox2, checkBox3, checkBox4,
                                    checkBox5, checkBox6, checkBox7, checkBox8,
                                    checkBox9, checkBox10, checkBoxEnableLogScale};
            var exts = checkboxes.Where(x => x.Checked)
                                 .Select(x => x.Text);
            Core.Config.SearchExtensions = exts.ToList();
        }

        /// <summary>
        /// DBからbodyとlensの情報を取得
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonExtractInfo_Click(object sender, EventArgs e)
        {
            groupBoxCreateHeatmap.Enabled = groupBox2.Enabled = groupBox3.Enabled = false;

            var cameras = new List<string>();
            var lenses = new List<string>();

            SetConfig();
            if (!File.Exists(Core.Config.SQLiteOutputPath)) { return; }

            await Task.Run(() =>
            {
                var sqlite = new SQLiteManager();
                cameras = sqlite.Query("select distinct model from statics order by model")
                                .Select(x => x.Model)
                                .Where(x => x != null)
                                .ToList();
                lenses = sqlite.Query("select distinct lenstype from statics order by lenstype")
                                .Select(x => x.LensType)
                                .Where(x => x != null)
                                .ToList();
            });
            if (cameras.Any() && lenses.Any())
            {
                listBoxBody.Items.AddRange(cameras.ToArray());
                listBoxLensType.Items.AddRange(lenses.ToArray());
            }
            groupBoxCreateHeatmap.Enabled = groupBox2.Enabled = groupBox3.Enabled = true;
        }

        /// <summary>
        /// heatmapを作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonCreateHeatMap_Click(object sender, EventArgs e)
        {
            groupBoxCreateHeatmap.Enabled = groupBox2.Enabled = groupBox3.Enabled = false;

            await CreateHeatMap();

            groupBoxCreateHeatmap.Enabled = groupBox2.Enabled = groupBox3.Enabled = true;
        }

        private async Task CreateHeatMap()
        {
            var FLbegin = (int)numericUpDownFlBegin.Value;
            var FLend = (int)numericUpDownFlEnd.Value;
            var t1 = dateTimePickerBegin.Value;
            var DateBegin = new DateTime(t1.Year, t1.Month, 1);
            var t2 = dateTimePickerEnd.Value;
            var DateEnd = new DateTime(t2.Year, t2.Month, 1);
            Bitmap image;
            var heatmapTitle = "";

            if (radioButtonByModels.Checked)
            {
                var cameraList = listBoxBody.SelectedItems.Cast<string>().ToList();
                if (!cameraList.Any()) { return; }

                heatmapTitle = string.Join(",", cameraList);

                image = await Task.Run(() =>
                {
                    var map = new HeatMap();
                    map.EnableLogScale = checkBoxEnableLogScale.Checked;
                    map.CreateCSVByModels(@"heatmap.csv", cameraList, DateBegin, DateEnd, FLbegin, FLend);
                    return map.CreateImage();
                });
            }
            else if (radioButtonByLensType.Checked)
            {
                var lenstype = listBoxLensType.SelectedItem.ToString();
                if (!lenstype.Any()) { return; }

                heatmapTitle = lenstype;

                image = await Task.Run(() =>
                {
                    var map = new HeatMap();
                    map.CreateCSVByLensType(@"heatmap.csv", lenstype, DateBegin, DateEnd, FLbegin, FLend);
                    return map.CreateImage();
                });
            }
            else { throw new ApplicationException(); }

            var form = new FormHeatmap();
            form.SetImage(image);
            form.CreateYLable(DateBegin, DateEnd);
            form.CreateXLabel(FLbegin, FLend);
            form.CreateColorBar();
            form.SetTitle(heatmapTitle);
            form.Show();
        }

        /// <summary>
        /// 検索フォルダを指定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectPicturesFolder_Click(object sender, EventArgs e)
        {
            var dialog = new FolderSelectDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (dialog.ShowDialog(IntPtr.Zero))
            {
                textBoxSearchDirectory.Text = dialog.FolderName;
            }
        }

        private void radioButtonByModels_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonByModels.Checked)
            {
                listBoxBody.Enabled = true;
                listBoxLensType.Enabled = false;
            }
        }

        private void radioButtonByLensType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonByLensType.Enabled)
            {
                listBoxBody.Enabled = false;
                listBoxLensType.Enabled = true;
            }
        }
    }
}