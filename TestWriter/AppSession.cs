using SCO.Managed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCO.TestWriter
{
	public class ScoAppSession
	{
		private frmMain mainWin;
		private string currentFilePath;
		private SCOFile scoFile;
		public SCOFile CurrentFile
		{
			get { return scoFile; }
		}
		public ScoAppSession(frmMain mainWin)
		{
			this.mainWin = mainWin;
		}

		public void New(string saveFilePath)
		{
			scoFile = new SCOFile();
			currentFilePath = saveFilePath;
			mainWin.SetState(FormState.New);
		}

		public void Open(string currentFile)
		{
			SCOLoader loader = new SCOLoader();
			scoFile = loader.Read(currentFile);
			currentFilePath = currentFile;
			mainWin.SetState(FormState.Open);
		}

		public void Save()
		{

		}
	}
}
