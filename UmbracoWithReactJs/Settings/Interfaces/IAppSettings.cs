using System.Net.Configuration;

namespace UmbracoWithReactJs.Settings.Interfaces
{
    public interface IAppSettings
    {
       SmtpSection MailSettings { get; }
       string EmailAlias { get; }
    }
}