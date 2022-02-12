using CM3D2.Toolkit.Guest4168Branch.Arc;
using CM3D2.Toolkit.Guest4168Branch.Arc.Entry;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcOutfitExtractorTool
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			form1 = new Form1();
			Application.Run(form1);


		}

		static Form1 form1;

		public static void ExtractFromDirectory(string dir)
		{
			string[] files = Directory.GetFiles(dir, "*.arc", SearchOption.AllDirectories);

			ExtractFilesFromFiles(files);
		}

		public static void ExtractFilesFromFiles(string[] files)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				fbd.ShowDialog();

				if (!String.IsNullOrEmpty(fbd.SelectedPath))
                {
					int cnt = 0;
					form1.textBox1.Clear();

					foreach (string fl in files)
					{
						ArcFileSystem fileSystem = new ArcFileSystem();
						fileSystem.LoadArc(fl);

						form1.textBox1.AppendText($"{fl} , {fileSystem.Files.Count} , {cnt} \r\n");
						form1.Refresh();

						bool s = fl.ToLower().StartsWith("script");

						foreach (ArcFileEntry f in fileSystem.Files.Values)
						{

							var p = f.Parent.FullName.Replace("CM3D2ToolKit:", String.Empty);

							if (!Directory.Exists(fbd.SelectedPath + p))
							{
								Directory.CreateDirectory(fbd.SelectedPath + p);
							}

							var decompressed = f.Pointer.Decompress();

                            if (s && form1.checkBox1.Checked && f.Name.EndsWith(".ks"))
                            {
								File.WriteAllTextAsync(fbd.SelectedPath + p + "\\" + f.Name, Encoding.GetEncoding(932).GetString(decompressed.Data));
							}
                            else
                            {
								File.WriteAllBytesAsync(fbd.SelectedPath + p + "\\" + f.Name, decompressed.Data);
							}
						}

						cnt += fileSystem.Files.Count;
						
					}

					form1.textBox1.AppendText($"Pulled {cnt} files. \r\n");

                }
			}
		}
	}
}
