using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPDM.Interop.epdm;

namespace TecTip_PDMVariable
{
    public partial class Form1 : Form
    {
        private const string PathToTestFile = @"C:\PATHTOFILEINVAULT\TESTFILE.SLDPRT";
        private const string VaultName = "VAULTNAME";
        private readonly IEdmVault7 _vault = new EdmVault5();
        public Form1()
        {
            InitializeComponent();
            if (!_vault.IsLoggedIn)
            {
                _vault.LoginAuto(VaultName, this.Handle.ToInt32());
            }
        }
        private void Button_Read_Click(object sender, EventArgs e)
        {
            IEdmFile5 file = _vault.GetFileFromPath(PathToTestFile, out IEdmFolder5 parentFolder);

            IEdmEnumeratorVariable10 enumeratorVariable = file.GetEnumeratorVariable() as IEdmEnumeratorVariable10;
            enumeratorVariable.GetVarAsText(TextBox_Read_Variable.Text, "Standard",parentFolder.ID, out object variablevalue);
            Label_Read_Value.Text = variablevalue.ToString();
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            IEdmFile5 file = _vault.GetFileFromPath(PathToTestFile, out IEdmFolder5 parentFolder);
            bool alreadyLocked = true;
            if (!file.IsLocked)
            {
                file.LockFile(parentFolder.ID, this.Handle.ToInt32());
                alreadyLocked = false;
            }

            IEdmBatchUpdate2 update = (IEdmBatchUpdate2)_vault.CreateUtility(EdmUtility.EdmUtil_BatchUpdate);
            object variableValue = TextBox_Update_Value.Text;
            update.SetVar(file.ID,GetVariableId(TextBox_Update_Variable.Text), variableValue,"Standard");
            update.CommitUpdate(out _);

            if (!alreadyLocked && file.IsLocked)
            {
                file.UnlockFile(this.Handle.ToInt32(), "CheckIn New Variable");
            }
        }

        private int GetVariableId(string variableName)
        {
            IEdmVariableMgr5 variableMgr = (IEdmVariableMgr5)_vault;
            return variableMgr.GetVariable(variableName).ID;
        }
    }
}
