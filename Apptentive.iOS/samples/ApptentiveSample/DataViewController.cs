using System;

using UIKit;
using ApptentiveSDK.iOS;

namespace ApptentiveSample
{
    public enum DataViewControllerSource: int {
        Person,
        Device
    }

    public partial class DataViewController : UIViewController
    {
        public DataViewControllerSource Source;

        protected DataViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            if (Source == DataViewControllerSource.Person)
            {
                nameTextField.Text = Apptentive.Shared.PersonName;
                emailTextField.Text = Apptentive.Shared.PersonEmailAddress;
            }
            else
            {
                nameTextField.Hidden = true;
                emailTextField.Hidden = true;
            }

            addButton.TouchUpInside += delegate {
                String key = keyTextField.Text.Trim();
                String text = dataTextField.Text.Trim();
                Boolean shouldClearFields = true;

                switch (typeControl.SelectedSegment)
                {
                    case 0:
                        if (text.Length > 0)
                        {
                            if (Source == DataViewControllerSource.Person)
                            {
                                Apptentive.Shared.AddCustomPersonData(text, key);
                            }
                            else
                            {
                                Apptentive.Shared.AddCustomDeviceData(text, key);
                            }
                        } else {
                            shouldClearFields = false;
                        }
                        break;
                    case 1:
                        float result;
                        if (text.Length > 0 && float.TryParse(text, out result))
                        {
                            if (Source == DataViewControllerSource.Person)
                            {
                                Apptentive.Shared.AddCustomPersonData(result, key);
                            }
                            else
                            {
                                Apptentive.Shared.AddCustomDeviceData(result, key);
                            }
                        } else {
                            shouldClearFields = false;
                        }
                        break;
                    case 2:
                        if (Source == DataViewControllerSource.Person)
                        {
                            Apptentive.Shared.AddCustomPersonData(booleanSwitch.On, key);
                        }
                        else
                        {
                            Apptentive.Shared.AddCustomDeviceData(booleanSwitch.On, key);
                        }
                        break;
                }

                if (shouldClearFields) {
                    keyTextField.Text = "";
                    dataTextField.Text = "";
                }
            };

            typeControl.ValueChanged += delegate
            {
                booleanSwitch.Hidden = (typeControl.SelectedSegment != 2);
                dataTextField.Hidden = (typeControl.SelectedSegment == 2);
            };

            nameTextField.EditingDidEnd += delegate
            {
                Apptentive.Shared.PersonName = nameTextField.Text;
            };

            emailTextField.EditingDidEnd += delegate
            {
                Apptentive.Shared.PersonEmailAddress = emailTextField.Text;
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

