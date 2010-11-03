using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace iMon.XBMC.Dialogs
{
    public partial class MappingDialog : Form
    {
        #region Private variables

        private Dictionary<string, List<string>> mapping;

        #endregion

        #region Public variables

        public Dictionary<string, List<string>> Mapping
        {
            get { return this.mapping; }
        }

        #endregion

        #region Constructor

        public MappingDialog(string title, string keys, string values, Dictionary<string, List<string>> mapping)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("title");
            }
            if (string.IsNullOrEmpty(keys))
            {
                throw new ArgumentException("keys");
            }
            if (string.IsNullOrEmpty(values))
            {
                throw new ArgumentException("values");
            }
            if (mapping == null || mapping.Keys.Count == 0)
            {
                throw new ArgumentException("mapping");
            }

            InitializeComponent();

            this.Text = title;

            this.lKeys.Text = keys;
            this.lValues.Text = values;

            this.mapping = mapping;

            foreach (string key in this.mapping.Keys)
            {
                this.lbKeys.Items.Add(key);
            }

            this.lbKeys.SelectedIndex = 0;
        }

        #endregion

        #region GUI handlers

        private void lbKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbKeys.SelectedIndex < 0)
            {
                this.lbValues.Items.Clear();
                return;
            }

            this.lbValues.Items.Clear();
            this.lbValues.SelectedIndex = -1;
            this.lbValues_SelectedIndexChanged(null, null);

            foreach (string value in this.mapping[this.lbKeys.SelectedItem.ToString()])
            {
                this.lbValues.Items.Add(value);
            }
        }

        private void lbValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbValues.SelectedIndex < 0)
            {
                this.bRemove.Enabled = false;
            }
            else
            {
                this.bRemove.Enabled = true;
            }
        }

        private void tbNewValue_TextChanged(object sender, EventArgs e)
        {
            this.bAdd.Enabled = !string.IsNullOrEmpty(this.tbNewValue.Text) && !this.lbValues.Items.Contains(this.tbNewValue.Text);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbNewValue.Text) || this.lbValues.Items.Contains(this.tbNewValue.Text))
            {
                this.bAdd.Enabled = false;
                return;
            }

            this.mapping[this.lbKeys.SelectedItem.ToString()].Add(this.tbNewValue.Text);
            this.lbValues.Items.Add(this.tbNewValue.Text);

            this.tbNewValue.Text = string.Empty;
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            if (this.lbValues.SelectedIndex < 0)
            {
                this.bRemove.Enabled = false;
                return;
            }

            this.mapping[this.lbKeys.SelectedItem.ToString()].Remove(this.lbValues.SelectedItem.ToString());
            this.lbValues.Items.RemoveAt(this.lbValues.SelectedIndex);

            this.lbValues.SelectedIndex = -1;
            this.lbValues_SelectedIndexChanged(null, null);
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        #endregion
    }
}
