using System;
using System.Collections.Generic;
using System.Runtime.InteropServices; // Clase para importar DLL

using PVOID = System.IntPtr;
using DWORD = System.UInt32;
using System.Windows;

namespace PicUSB
{
    unsafe public class PicUSBAPI
    {
        #region Definición de los Strings: EndPoint y VID_PID
        string vid_pid_norm = "vid_04d8&pid_0011";

        string out_pipe = "\\MCHP_EP1";
        string in_pipe = "\\MCHP_EP1";
        #endregion

        #region Funciones importadas de la DLL: mpusbapi.dll
        [DllImport("mpusbapi.dll")]
        private static extern DWORD _MPUSBGetDLLVersion();
        [DllImport("mpusbapi.dll")]
        private static extern DWORD _MPUSBGetDeviceCount(string pVID_PID);
        [DllImport("mpusbapi.dll")]
        private static extern void* _MPUSBOpen(DWORD instance, string pVID_PID, string pEP, DWORD dwDir, DWORD dwReserved);
        [DllImport("mpusbapi.dll")]
        private static extern DWORD _MPUSBRead(void* handle, void* pData, DWORD dwLen, DWORD* pLength, DWORD dwMilliseconds);
        [DllImport("mpusbapi.dll")]
        private static extern DWORD _MPUSBWrite(void* handle, void* pData, DWORD dwLen, DWORD* pLength, DWORD dwMilliseconds);
        [DllImport("mpusbapi.dll")]
        private static extern DWORD _MPUSBReadInt(void* handle, DWORD* pData, DWORD dwLen, DWORD* pLength, DWORD dwMilliseconds);
        [DllImport("mpusbapi.dll")]
        private static extern bool _MPUSBClose(void* handle);
        #endregion

        void* myOutPipe;
        void* myInPipe;
                
        public void OpenPipes()
        {
            DWORD selection = 0;

            myOutPipe = _MPUSBOpen(selection, vid_pid_norm, out_pipe, 0, 0);
            myInPipe = _MPUSBOpen(selection, vid_pid_norm, in_pipe, 1, 0);
        }

        public void ClosePipes()
        {
            _MPUSBClose(myOutPipe);
            _MPUSBClose(myInPipe);
        }

        private void SendPacket(byte* SendData, DWORD SendLength)
        {
            uint SendDelay = 1000;

            DWORD SentDataLength;

            OpenPipes();
            _MPUSBWrite(myOutPipe, (void*)SendData, SendLength, &SentDataLength, SendDelay);
            ClosePipes();
        }

        private void ReceivePacket(byte* ReceiveData, DWORD* ReceiveLength)
        {
            uint ReceiveDelay = 1000;

            DWORD ExpectedReceiveLength = *ReceiveLength;

            OpenPipes();
            _MPUSBRead(myInPipe, (void*)ReceiveData, ExpectedReceiveLength, ReceiveLength, ReceiveDelay);
            ClosePipes();
        }

        public void ControleMP(uint dir_x, uint value_x, uint dir_y, uint value_y, uint z)
        {
            byte* send_buf = stackalloc byte[5];

            send_buf[0] = (byte)0x01;             // Código de Entrada a Modo Controle do Carrinho
            send_buf[1] = (byte)dir_x;
            send_buf[2] = (byte)value_x;
            send_buf[3] = (byte)dir_y;
            send_buf[4] = (byte)value_y;
            SendPacket(send_buf, 5);
        }

        public int Status_PIC()
        {
            int status_now=0;

            byte* send_buf = stackalloc byte[1];
            send_buf[0] = 0x04;
            SendPacket(send_buf, 1);
            byte* receive_buf = stackalloc byte[1];

            DWORD RecvLength = 1;

            ReceivePacket(receive_buf, &RecvLength);
            status_now = receive_buf[0];

            return status_now;
        }
    }
}