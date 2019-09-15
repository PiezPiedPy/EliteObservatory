﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Observatory
{
    public partial class SettingsFrm : Form
    {
        private Properties.Observatory settings;
        private ObservatoryFrm mainForm;

        public SettingsFrm(ObservatoryFrm mainForm)
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            settings = Properties.Observatory.Default;
            this.mainForm = mainForm;
        }

        private void SettingsFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.settingsOpen = false;
        }

        private void SettingsFrm_Load(object sender, EventArgs e)
        {
            cbx_LandWithTerra.Checked = settings.LandWithTerra;
            cbx_LandWithAtmo.Checked = settings.LandWithAtmo;
            cbx_LandHighG.Checked = settings.LandHighG;
            cbx_AllJumpBody.Checked = settings.AllJumpBody;
            cbx_AllJumpSystem.Checked = settings.AllJumpSystem;
            cbx_CloseBinary.Checked = settings.CloseBinary;
            cbx_CloseOrbit.Checked = settings.CloseOrbit;
            cbx_CollidingBinary.Checked = settings.CollidingBinary;
            cbx_FastOrbit.Checked = settings.FastOrbit;
            cbx_FastRotate.Checked = settings.FastRotate;
            cbx_GoodJump.Checked = settings.GoodJump;
            cbx_HighEccentric.Checked = settings.HighEccentric;
            cbx_NestedMoon.Checked = settings.NestedMoon;
            cbx_ShepherdMoon.Checked = settings.ShepherdMoon;
            cbx_TinyObject.Checked = settings.TinyObject;
            cbx_VeryInteresting.Checked = settings.VeryInteresting;
            cbxToast.Checked = settings.Notify;
            cbxTts.Checked = settings.TTS;
            txtCopy.Text = settings.CopyTemplate;
            cbx_custom.Checked = settings.CustomRules;
            cbx_LandLarge.Checked = settings.LandLarge;
            cbx_WideRing.Checked = settings.WideRing;
        }

        private void Cbx_LandWithTerra_CheckedChanged(object sender, EventArgs e)
        {
            settings.LandWithTerra = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_LandWithAtmo_CheckedChanged(object sender, EventArgs e)
        {
            settings.LandWithAtmo = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_LandHighG_CheckedChanged(object sender, EventArgs e)
        {
            settings.LandHighG = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_CloseOrbit_CheckedChanged(object sender, EventArgs e)
        {
            settings.CloseOrbit = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_ShepherdMoon_CheckedChanged(object sender, EventArgs e)
        {
            settings.ShepherdMoon = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_CloseBinary_CheckedChanged(object sender, EventArgs e)
        {
            settings.CloseBinary = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_CollidingBinary_CheckedChanged(object sender, EventArgs e)
        {
            settings.CollidingBinary = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_NestedMoon_CheckedChanged(object sender, EventArgs e)
        {
            settings.NestedMoon = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_TinyObject_CheckedChanged(object sender, EventArgs e)
        {
            settings.TinyObject = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_FastRotate_CheckedChanged(object sender, EventArgs e)
        {
            settings.FastRotate = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_FastOrbit_CheckedChanged(object sender, EventArgs e)
        {
            settings.FastOrbit = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_HighEccentric_CheckedChanged(object sender, EventArgs e)
        {
            settings.HighEccentric = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_GoodJump_CheckedChanged(object sender, EventArgs e)
        {
            settings.GoodJump = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_AllJumpBody_CheckedChanged(object sender, EventArgs e)
        {
            settings.AllJumpBody = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_AllJumpSystem_CheckedChanged(object sender, EventArgs e)
        {
            settings.AllJumpSystem = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_VeryInteresting_CheckedChanged(object sender, EventArgs e)
        {
            settings.VeryInteresting = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void CbxToast_CheckedChanged(object sender, EventArgs e)
        {
            mainForm.Notify = ((CheckBox)sender).Checked;
            settings.Notify = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void CbxTts_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTts.Checked)
            {
                mainForm.speech = new System.Speech.Synthesis.SpeechSynthesizer();
                mainForm.speech.SetOutputToDefaultAudioDevice();
                //cbxTtsDetail.Visible = true;
            }
            else
            {
                mainForm.speech.Dispose();
                //cbxTtsDetail.Visible = false;
            }
            settings.TTS = cbxTts.Checked;
            settings.Save();
        }

        private void BtnCopyReset_Click(object sender, EventArgs e)
        {
            txtCopy.Text = "%time% - %bodyL% - %info% - %detail%";
        }

        private void TxtCopy_TextChanged(object sender, EventArgs e)
        {
            settings.CopyTemplate = txtCopy.Text;
            settings.Save();
        }

        private void Cbx_custom_CheckedChanged(object sender, EventArgs e)
        {
            settings.CustomRules = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_LandLarge_CheckedChanged(object sender, EventArgs e)
        {
            settings.LandLarge = ((CheckBox)sender).Checked;
            settings.Save();
        }

        private void Cbx_WideRing_CheckedChanged(object sender, EventArgs e)
        {
            settings.WideRing = ((CheckBox)sender).Checked;
            settings.Save();
        }
    }
}
