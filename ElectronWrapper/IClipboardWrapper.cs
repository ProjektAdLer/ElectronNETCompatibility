using ElectronNET.API.Entities;
using System.Threading.Tasks;

namespace ElectronWrapper
{
    interface IClipboardWrapper
    {
        Task<string[]> AvailableFormatsAsync(string type = "");
        void Clear(string type = "");
        Task<ReadBookmark> ReadBookmarkAsync();
        Task<string> ReadFindTextAsync();
        Task<string> ReadHTMLAsync(string type = "");
        Task<NativeImage> ReadImageAsync(string type = "");
        Task<string> ReadRTFAsync(string type = "");
        Task<string> ReadTextAsync(string type = "");
        void Write(Data data, string type = "");
        void WriteBookmark(string title, string url, string type = "");
        void WriteFindText(string text);
        void WriteHTML(string markup, string type = "");
        void WriteImage(NativeImage image, string type = "");
        void WriteRTF(string text, string type = "");
        void WriteText(string text, string type = "");
    }
}