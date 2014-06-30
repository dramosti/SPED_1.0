using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Security.AccessControl;

namespace Hlp.Sped.Domain.Models
{
    public static class Util
    {
        public static string GetPastaConfiguracao()
        {
            try
            {
                RegistryKey key = Registry.CurrentConfig.OpenSubKey("hlp\\Config_sped");
                if (key != null)
                {
                    return key.GetValue("conexoes", "").ToString() ;

                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("O Sistema não conseguiu acessar o caminho hlp\\Config_xml_3 no Registro do Windows");
            }
        }

        public static void SalvarRegistro(string sValor)
        {
            string user = Environment.UserDomainName + "\\" + Environment.UserName;
            RegistrySecurity rs = new RegistrySecurity();
            rs.AddAccessRule(new RegistryAccessRule(user,
            RegistryRights.FullControl,
            InheritanceFlags.None,
            PropagationFlags.None,
            AccessControlType.Allow));

            RegistryKey rk = Registry.CurrentConfig.OpenSubKey("hlp", true);
            rk = rk.CreateSubKey("Config_sped", RegistryKeyPermissionCheck.Default, rs);
            rk.SetValue("conexoes", sValor);

        }

    }
}
