// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ApptentiveSample
{
    [Register ("DataViewController")]
    partial class DataViewController
    {
        [Outlet]
        UIKit.UIButton addButton { get; set; }

        [Outlet]
        UIKit.UISwitch booleanSwitch { get; set; }

        [Outlet]
        UIKit.UITextField dataTextField { get; set; }

        [Outlet]
        UIKit.UITextField emailTextField { get; set; }

        [Outlet]
        UIKit.UITextField keyTextField { get; set; }

        [Outlet]
        UIKit.UITextField nameTextField { get; set; }

        [Outlet]
        UIKit.UISegmentedControl typeControl { get; set; }
        
        void ReleaseDesignerOutlets ()
        {
            if (typeControl != null) {
                typeControl.Dispose ();
                typeControl = null;
            }

            if (booleanSwitch != null) {
                booleanSwitch.Dispose ();
                booleanSwitch = null;
            }

            if (dataTextField != null) {
                dataTextField.Dispose ();
                dataTextField = null;
            }

            if (nameTextField != null) {
                nameTextField.Dispose ();
                nameTextField = null;
            }

            if (emailTextField != null) {
                emailTextField.Dispose ();
                emailTextField = null;
            }

            if (addButton != null) {
                addButton.Dispose ();
                addButton = null;
            }

            if (keyTextField != null) {
                keyTextField.Dispose ();
                keyTextField = null;
            }
        }
    }
}
