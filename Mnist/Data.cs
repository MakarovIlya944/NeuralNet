﻿using MathNet.Numerics.LinearAlgebra;

namespace Mnist
{
    public class Data
    {
        public Vector<double>[] signal;
        public Vector<double>[] answer;

        public Matrix<double> AllSignal { get => Matrix<double>.Build.DenseOfRowVectors(signal); }
        public Matrix<double> AllAnswer { get => Matrix<double>.Build.DenseOfRowVectors(answer); }

        public int InputDataSize { get => input; }
        public int input, output;

        public Data(Vector<double>[] signal, Vector<double>[] answer)
        {
            this.signal = signal;
            this.answer = answer;
            this.input = signal.Length;
            this.output = answer.Length;
        }

        public Data(int input, int output)
        {
            this.input = input;
            this.output = output;
        }

        public Data this[int index]
        {
            get => new Data(new Vector<double>[1] { signal[index] }, new Vector<double>[1] { answer[index] });
        }
    }
}
