using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetableManager
{
    public partial class FormMain : Form
    {
        private Module brp;
        private Module currentModule;

        /// <summary>
        /// Main form constructor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loading modules and initialising UI controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            brp = new Module("MCOMD2BRP", "Object Oriented Programming");
            comboBoxModuleSelector.Items.Add(brp.GetCode());
            comboBoxModuleSelector.SelectedIndex = 0;
        }

        /// <summary>
        /// Updating the currentModule variable depending on module selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxModuleSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxModuleSelector.SelectedIndex)
            {
                case 0:
                    currentModule = brp;
                    break;
                default:
                    currentModule = brp;
                    break;
            }
            ShowCurrentModule();
        }

        /// <summary>
        /// Updating all necessary UI controls from the currentModule
        /// </summary>
        private void ShowCurrentModule()
        {
            // textBoxModuleDescription.Text = currentModule.GetDescription();
        }
    }
}
