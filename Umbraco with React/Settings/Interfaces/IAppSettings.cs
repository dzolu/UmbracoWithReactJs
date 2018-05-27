using System.Net.Configuration;

namespace Knowhere_CMS.Settings.Interfaces
{
    public interface IAppSettings
    {
       SmtpSection MailSettings { get; }
       string EmailAlias { get; }
    }
}