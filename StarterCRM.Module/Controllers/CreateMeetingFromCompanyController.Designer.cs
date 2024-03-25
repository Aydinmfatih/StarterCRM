namespace StarterCRM.Module.Controllers
{
    partial class CreateMeetingFromCompanyController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.actionCreateMeeting = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // actionCreateMeeting
            // 
            this.actionCreateMeeting.AcceptButtonCaption = null;
            this.actionCreateMeeting.CancelButtonCaption = null;
            this.actionCreateMeeting.Caption = "Create Meeting";
            this.actionCreateMeeting.ConfirmationMessage = null;
            this.actionCreateMeeting.Id = "actionCreateMeeting";
            this.actionCreateMeeting.ImageName = "BO_Scheduler";
            this.actionCreateMeeting.ToolTip = null;
            this.actionCreateMeeting.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.actionCreateMeeting_CustomizePopupWindowParams);
            // 
            // CreateMeetingFromCompanyController
            // 
            this.Actions.Add(this.actionCreateMeeting);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction actionCreateMeeting;
    }
}
