/*=============================================================================
	File		:	Visa.cs                 
	Author		:	Vikas Rao
	Description	:	
	See Also	:   
	Revisions	:	
	----------------------------------------------------------------
		Date					Who					What
		22 Jan, 2010 		  Vikas Rao   		Initial Version
        19 Sept, 2013         Glenn             Only needed one to extended the other VISA
	----------------------------------------------------------------
		Copyright (c) 2008-2009 Tektronix. All Rights Reserved.
	----------------------------------------------------------------
=============================================================================*/
using System;
using System.Runtime.InteropServices;


namespace AwgTestFramework
{
    public class VisaExtensions
	{
        
		private uint	_instrSession = 0;

	    public uint Session
	    {
	        get { return _instrSession; }
            set { _instrSession = value; }
	    }

		#region VISA IMPORTS
		
        [DllImport("visa32.dll")]
        static extern int viWrite(uint _instrSession, byte[] buffer, uint count, out uint retCount);

		#endregion

	    public TekVISANet.VISA WorkingSession;

        public VisaExtensions(TekVISANet.VISA workingSession)
		{
            WorkingSession = workingSession;
		}
	
		#region Write

        public bool Write(Byte[] InputBuffer)
        {
            uint    returnCount = (uint)InputBuffer.Length;
            return false == WorkingSession.OnErrorHandler((TekVISANet.TekVISADefs.Status)viWrite(_instrSession, InputBuffer, returnCount, out returnCount));
        }

		#endregion
	}
}
