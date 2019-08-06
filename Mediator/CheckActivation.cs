using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Mediator
{
    class CheckActivation
    {
        static string path = AppDomain.CurrentDomain.BaseDirectory +Application.ProductName +".UPTOP";


        public static void ActivateProducts(string ActivationKey)
        {
            try
            {
                Encrypt encrypt = new Encrypt();
                string date = encrypt.Decryption(ActivationKey, encrypt.GenerateEncryptionKey());

                DateTime trial = DateTime.Parse(date);
                DateTime now = DateTime.Now;

                if (trial.Date >= now.Date)
                {
                    File.WriteAllText(path, ActivationKey);
                }
                else
                {
                    MessageBox.Show("الكود منتهى أو غير صحيح", "فشل التفعيل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("الكود منتهى أو غير صحيح", "فشل التفعيل", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static bool IsActivated()
        {
            bool IsActivated = false;
            try
            {
                if (File.Exists(path))
                {
                    string activationkey = File.ReadAllText(path);
                    Encrypt Encrypt = new Encrypt();

                    if (activationkey != "" && activationkey != null && activationkey != string.Empty)
                    {
                        string date = Encrypt.Decryption(activationkey, Encrypt.GenerateEncryptionKey());

                        DateTime trial = DateTime.Parse(date);
                        DateTime now = DateTime.Now;

                        if (trial.Date >= now.Date)
                        {
                            IsActivated = true;
                        }
                        else
                        {
                            IsActivated = false;
                        }
                    }
                }
                else
                {
                    IsActivated = false;
                }

            }
            catch (Exception)
            {
                IsActivated = false;
            }

            return IsActivated;
        }


        public static bool IsExists()
        {
            bool IsActivated = false;
            try
            {
                if (File.Exists(path))
                {
                    IsActivated = true;
                }
                else
                {
                    IsActivated = false;
                }

            }
            catch (Exception)
            {
                IsActivated = false;
            }

            return IsActivated;
        }















    }
}
