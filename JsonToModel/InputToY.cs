using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonToModel
{
    public partial class InputToY : Form
    {
        public InputToY()
        {
            InitializeComponent();
        }

        [JsonProperty("Message")]
        public string Message { get; set; }

        string modelTemplate0 = @"[JsonProperty({0})]";
        string modelTemplate1 = @"public string {0} ";

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                var list = JsonConvert.DeserializeObject<dynamic>(rbJson.Text);
                StringBuilder sb = new StringBuilder();
                foreach (var item in list)
                {
                    var m1 = string.Format(modelTemplate0, "\"" + item.Name + "\"");
                    sb.AppendLine(m1);
                    var m2 = string.Format(modelTemplate1, item.Name + " { get; set; }");
                    sb.AppendLine(m2);
                    sb.AppendLine();
                }
                rbModel.Text = sb.ToString();
            }
            catch
            {
                MessageBox.Show("转化失败");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rbJson.Text = string.Empty;
        }
    }
}
