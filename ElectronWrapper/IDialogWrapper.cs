using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronNET.API;
using ElectronNET.API.Entities;

namespace ElectronWrapper
{
    interface IDialogWrapper
    {
        Task<string[]> ShowOpenDialogAsync(BrowserWindow browserWindow, OpenDialogOptions options);
        Task<string> ShowSaveDialogAsync(BrowserWindow browserWindow, SaveDialogOptions options);
        Task<MessageBoxResult> ShowMessageBoxAsync(string message);
        Task<MessageBoxResult> ShowMessageBoxAsync(MessageBoxOptions messageBoxOptions);
        Task<MessageBoxResult> ShowMessageBoxAsync(BrowserWindow browserWindow, string message);
        Task<MessageBoxResult> ShowMessageBoxAsync(BrowserWindow browserWindow, MessageBoxOptions messageBoxOptions);
        Task ShowCertificateTrustDialogAsync(CertificateTrustDialogOptions options);
        Task ShowCertificateTrustDialogAsync(BrowserWindow browserWindow, CertificateTrustDialogOptions options);
    }
}
