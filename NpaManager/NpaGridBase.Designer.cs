namespace NpaManager {
   partial class NpaGridBase {
      /// <summary> 
      /// Требуется переменная конструктора.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Освободить все используемые ресурсы.
      /// </summary>
      /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Код, автоматически созданный конструктором компонентов

      /// <summary> 
      /// Обязательный метод для поддержки конструктора - не изменяйте 
      /// содержимое данного метода при помощи редактора кода.
      /// </summary>
      private void InitializeComponent() {
         this.components = new System.ComponentModel.Container();
         this.DS = new NpaManager.NpaDataSet();
         this.bindingSrc = new System.Windows.Forms.BindingSource(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSrc)).BeginInit();
         this.SuspendLayout();
         // 
         // DS
         // 
         this.DS.DataSetName = "NpaDataSet";
         this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // bindingSrc
         // 
         this.bindingSrc.DataSource = this.DS;
         this.bindingSrc.Position = 0;
         this.bindingSrc.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSrc_ListChanged);
         // 
         // NpaGridBase
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Name = "NpaGridBase";
         this.Size = new System.Drawing.Size(353, 325);
         ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSrc)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      protected System.Windows.Forms.BindingSource bindingSrc;
      protected NpaDataSet DS;

   }
}
