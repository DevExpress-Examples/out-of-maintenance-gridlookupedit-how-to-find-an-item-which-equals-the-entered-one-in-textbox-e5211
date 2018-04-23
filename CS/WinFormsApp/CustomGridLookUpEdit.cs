using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsApp;

namespace WinFormsApp{
   
        [ToolboxItem(true)]
        public class CustomGridLookUpEdit : GridLookUpEdit
        {
            static CustomGridLookUpEdit() { RepositoryItemCustomridLookUpEdit.RegisterCustomEdit(); }
                       
            public CustomGridLookUpEdit()
            {
               
            }
                       
            public override string EditorTypeName
            {
                get
                {
                    return
                        RepositoryItemCustomridLookUpEdit.CustomEditName;
                }
            }

            [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
            public new RepositoryItemCustomridLookUpEdit Properties
            {
                get { return base.Properties as RepositoryItemCustomridLookUpEdit; }
            }
            
            protected override int FindItem(string text, int startIndex)
            {
                if (!IsReady) return -1;
                int index = Properties.MyFindItem(text);
                return index;
            }           
        }
    
    [UserRepositoryItem("RegisterCustomEdit")]
    public class RepositoryItemCustomridLookUpEdit : RepositoryItemGridLookUpEdit
    {

        static RepositoryItemCustomridLookUpEdit() { RegisterCustomEdit(); }

       
        public RepositoryItemCustomridLookUpEdit()
        {
            
        }

        public const string CustomEditName = "CustomGridLookUpEdit";

       
        public override string EditorTypeName { get { return CustomEditName; } }

        
        public static void RegisterCustomEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName,
              typeof(CustomGridLookUpEdit), typeof(RepositoryItemCustomridLookUpEdit),
              typeof(GridLookUpEditBaseViewInfo), new ButtonEditPainter(), true, null));             
        }

        public int MyFindItem(string text)
        {
            int resultItemIndex = FindItem(text, false);
            if (resultItemIndex == -1)
                resultItemIndex = FindItem(text, true);
            return resultItemIndex;
        }

    }

}
