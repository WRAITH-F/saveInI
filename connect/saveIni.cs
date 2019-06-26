using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connect
{
    public partial class saveInI : Form
    {
        IniFiles ini = new IniFiles(Application.StartupPath + @"\MyConfig.INI");
        public saveInI()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            //写入数据
            ini.IniWriteValue("登入详细", "用户名", "test");
            ini.IniWriteValue("登入详细", "密码", "password");

            //验证是否存在配置文件，存在就读取
            if (ini.ExistINIFile())
            {
                var text = ini.IniReadValue("登入详细", "用户名");
                MessageBox.Show(text);
            }
        }
    }
}
