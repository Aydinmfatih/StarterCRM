﻿namespace StarterCRM.Win {
    partial class StarterCRMWindowsFormsApplication {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
            this.module3 = new StarterCRM.Module.StarterCRMModule();
            this.module4 = new StarterCRM.Module.Win.StarterCRMWindowsFormsModule();
            this.objectsModule = new DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule();
            this.conditionalAppearanceModule = new DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule();
            this.schedulerModuleBase = new DevExpress.ExpressApp.Scheduler.SchedulerModuleBase();
            this.schedulerWindowsFormsModule = new DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule();
            this.validationModule = new DevExpress.ExpressApp.Validation.ValidationModule();
            this.validationWindowsFormsModule = new DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            //
            // validationModule
            //
            this.validationModule.AllowValidationDetailsAccess = false;
            // 
            // StarterCRMWindowsFormsApplication
            // 
            this.ApplicationName = "StarterCRM";
            this.CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema;
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module4);
            this.Modules.Add(this.objectsModule);
            this.Modules.Add(this.conditionalAppearanceModule);
            this.Modules.Add(this.schedulerModuleBase);
            this.Modules.Add(this.schedulerWindowsFormsModule);
            this.Modules.Add(this.validationModule);
            this.Modules.Add(this.validationWindowsFormsModule);
            this.UseOldTemplates = false;
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.StarterCRMWindowsFormsApplication_DatabaseVersionMismatch);
            this.CustomizeLanguagesList += new System.EventHandler<DevExpress.ExpressApp.CustomizeLanguagesListEventArgs>(this.StarterCRMWindowsFormsApplication_CustomizeLanguagesList);

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
        private StarterCRM.Module.StarterCRMModule module3;
        private StarterCRM.Module.Win.StarterCRMWindowsFormsModule module4;
        private DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule objectsModule;
        private DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule conditionalAppearanceModule;
        private DevExpress.ExpressApp.Scheduler.SchedulerModuleBase schedulerModuleBase;
        private DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule schedulerWindowsFormsModule;
        private DevExpress.ExpressApp.Validation.ValidationModule validationModule;
        private DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule validationWindowsFormsModule;
    }
}
