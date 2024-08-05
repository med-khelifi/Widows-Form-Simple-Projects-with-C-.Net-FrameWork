using System;
using System.Windows.Forms;

namespace Project9__BankManagementSystem
{
    public partial class frmPermissions : Form
    {
        public frmPermissions()
        {
            InitializeComponent();
        }

       
        private void tsAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            SetAllPermissions(tsAllPermissions.Checked);
        }

        private void SetAllPermissions(bool isChecked)
        {
            tsManageClients.Checked = isChecked;
            tsManageUsers.Checked = isChecked;
            tsTransActions.Checked = isChecked;
            tsCurrencyExchange.Checked = isChecked;
            tsLogingHistory.Checked = isChecked;
        }

        private void tsManageUsers_CheckedChanged(object sender, EventArgs e)
        {
            SetManageUsersPermissions(tsManageUsers.Checked);
            //tsAllPermissions.Checked = AreAllPermissionsChecked();
        }

        private void SetManageUsersPermissions(bool isChecked)
        {
            chkAddNewUser.Checked = isChecked;
            chkShowUsersList.Checked = isChecked;
            chkDeleteUser.Checked = isChecked;
            chkUpdateUser.Checked = isChecked;
        }

        private void tsManageClients_CheckedChanged(object sender, EventArgs e)
        {
            SetManageClientsPermissions(tsManageClients.Checked);
            //tsAllPermissions.Checked = AreAllPermissionsChecked();
        }

        private void SetManageClientsPermissions(bool isChecked)
        {
            chkAddNewClients.Checked = isChecked;
            chkShowClientsList.Checked = isChecked;
            chkDeleteCLient.Checked = isChecked;
            chkUpdateClient.Checked = isChecked;
        }

        private void tsTransActions_CheckedChanged(object sender, EventArgs e)
        {
            SetTransactionPermissions(tsTransActions.Checked);
           // tsAllPermissions.Checked = AreAllPermissionsChecked();
        }

        private void SetTransactionPermissions(bool isChecked)
        {
            chkDeposit.Checked = isChecked;
            chkWithdraw.Checked = isChecked;
            chkTransfer.Checked = isChecked;
            chkTransferLogs.Checked = isChecked;
        }

        private void tsCurrencyExchange_CheckedChanged(object sender, EventArgs e)
        {
            SetCurrencyExchangePermissions(tsCurrencyExchange.Checked);
            //tsAllPermissions.Checked = AreAllPermissionsChecked();
        }

        private void SetCurrencyExchangePermissions(bool isChecked)
        {
            chkShowCurrencyList.Checked = isChecked;
            chkUpdateCurrencyRate.Checked = isChecked;
            chkExchange.Checked = isChecked;
        }

        private bool AreAllPermissionsChecked()
        {
            return tsManageClients.Checked
                && tsManageUsers.Checked
                && tsTransActions.Checked
                && tsCurrencyExchange.Checked
                && tsLogingHistory.Checked;
        }

        private bool AreManageUsersFlagsChecked()
        {
            return chkAddNewUser.Checked
                && chkShowUsersList.Checked
                && chkUpdateUser.Checked
                && chkDeleteUser.Checked;
        }

        private bool AreManageClientsFlagsChecked()
        {
            return chkAddNewClients.Checked
                && chkShowClientsList.Checked
                && chkUpdateClient.Checked
                && chkDeleteCLient.Checked;
        }

        private bool AreTransactionFlagsChecked()
        {
            return chkDeposit.Checked
                && chkWithdraw.Checked
                && chkTransfer.Checked
                && chkTransferLogs.Checked;
        }

        private bool AreCurrencyFlagsChecked()
        {
            return chkShowCurrencyList.Checked
                && chkUpdateCurrencyRate.Checked
                && chkExchange.Checked;
        }

        private void chkManageUsersChanged(object sender, EventArgs e)
        {
         //   tsManageUsers.Checked = AreManageUsersFlagsChecked();
        }

        private void chkManageClientsChanged(object sender, EventArgs e)
        {
            //tsManageClients.Checked = AreManageClientsFlagsChecked();
        }

        private void chkTransactionsChanged(object sender, EventArgs e)
        {
          //  tsTransActions.Checked = AreTransactionFlagsChecked();
        }

        private void chkCurrencyExchangeChanged(object sender, EventArgs e)
        {
          //  tsCurrencyExchange.Checked = AreCurrencyFlagsChecked();
        }

        public int GetPermissions()
        {
            if (tsAllPermissions.Checked)
            {
                return -1;
            }
            int Permissions = 0;

            if (chkShowClientsList.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eShowClientsList;
            }

            if (chkAddNewClients.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eAddNewClients;
            }

            if (chkUpdateClient.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eUpdateClient;
            }

            if (chkDeleteCLient.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eDeleteClient;
            }


            if (chkShowUsersList.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eShowUsersList;
            }

            if (chkAddNewUser.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eAddNewUser;
            }

            if (chkUpdateUser.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eUpdateUser;
            }

            if (chkDeleteUser.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eDeleteUser;
            }



            if(chkDeposit.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eDeposit;
            }

            if (chkWithdraw.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eWithdraw;
            }
            if (chkTransfer.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eTransfer;
            }
            if (chkTransferLogs.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eTransferHistory;
            }



            if (chkShowCurrencyList.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eShowCurrencyList;
            }
            if (chkUpdateCurrencyRate.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eUpdateCurrecyRate;
            }

            if (chkExchange.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eExchangeCurrency;
            }

            if (tsLogingHistory.Checked)
            {
                Permissions += (int)clsUsers.enPermession.eLogingHistory;
            }

            return Permissions;
        }

        private void btnSETPermissions_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
