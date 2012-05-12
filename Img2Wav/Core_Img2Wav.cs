using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using WaveLibrary;

namespace Img2Wav
{
    
    
    class Core_Img2Wav
    {
        
        private const double MAX_DATA = +50;
        private const double MIN_DATA = -50;

        private const String NoInputBitmap = "No input bitmap";

        public Bitmap InputBitmap { get; set; }
        public WaveFile OutputWav { get; set; }

        public void Start()
        {
            int NumSamples = InputBitmap.Width * InputBitmap.Height;
            
            byte[] Samples = new byte[NumSamples];

            OutputWav = new WaveFile(1, 16, 44000);

            if (InputBitmap == null) throw new Exception(NoInputBitmap);

            double[] data = new double[InputBitmap.Height];


            int w = 0;
            for (int i = 0; i < InputBitmap.Width; i++) 
            {
                for (int j = 0; j < InputBitmap.Height; j++)
                {

                    Color C = InputBitmap.GetPixel(i,j);

                    data[j] = (C.R + C.G + C.B ) / 3;


                }

                FFT_Img2Wav.inverse(data);
                
                // Ciclo per tutti i data
                for (int x = 0; x < data.Length; x++)
                {
                    Samples[w] = (byte)(MAX_DATA * data[x]);
                    w++;
                }


            }

            OutputWav.SetData(Samples,NumSamples);

        }
    }
}
