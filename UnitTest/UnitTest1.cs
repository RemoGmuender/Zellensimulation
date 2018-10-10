using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zellensimulation;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestResetBoard()
        {
            var board = new Board(20);

            board.SetValue(1,1,true);

            board.Reset();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Assert.IsFalse(board.GetValue(i,j));
                }
            }
        }

        [TestMethod]
        public void TestKomischeForm()
        {
            var board = new Board(20);

            board.SetValue(0, 1, true);
            board.SetValue(1, 2, true);
            board.SetValue(2, 0, true);
            board.SetValue(2, 1, true);
            board.SetValue(2, 2, true);

            board.CalcNextGen();

            Assert.IsTrue(board.GetValue(1, 0));
            Assert.IsTrue(board.GetValue(1, 2));
            Assert.IsTrue(board.GetValue(2, 1));
            Assert.IsTrue(board.GetValue(2, 2));
            Assert.IsTrue(board.GetValue(3, 1));
            Assert.AreEqual(5, board.CountAlive());

        }

        [TestMethod]
        public void TestKomischeFormEcke()
        {
            var board = new Board(20);

            board.SetValue(19, 19, true);
            board.SetValue(19, 18, true);
            board.SetValue(18, 19, true);
            board.SetValue(19, 17, true);
            board.SetValue(17, 18, true);

            board.CalcNextGen();

            Assert.IsTrue(board.GetValue(19, 19));
            Assert.IsTrue(board.GetValue(19, 18));
            Assert.IsTrue(board.GetValue(18, 19));
            Assert.IsTrue(board.GetValue(18, 17));
            Assert.AreEqual(4, board.CountAlive());

        }

        [TestMethod]
        public void TestKreuz2SchritteEcke()
        {
            var board = new Board(20);

            board.SetValue(0, 1, true);
            board.SetValue(1, 0, true);
            board.SetValue(1, 1, true);
            board.SetValue(1, 2, true);
            board.SetValue(2, 1, true);

            board.CalcNextGen();

            Assert.IsTrue(board.GetValue(0, 0));
            Assert.IsTrue(board.GetValue(0, 1));
            Assert.IsTrue(board.GetValue(0, 2));
            Assert.IsTrue(board.GetValue(1, 0));
            Assert.IsTrue(board.GetValue(1, 2));
            Assert.IsTrue(board.GetValue(2, 0));
            Assert.IsTrue(board.GetValue(2, 1));
            Assert.IsTrue(board.GetValue(2, 2));
            Assert.AreEqual(8, board.CountAlive());

            board.CalcNextGen();

            Assert.IsTrue(board.GetValue(0, 0));
            Assert.IsTrue(board.GetValue(0, 2));
            Assert.IsTrue(board.GetValue(1, 3));
            Assert.IsTrue(board.GetValue(2, 2));
            Assert.IsTrue(board.GetValue(3, 1));
            Assert.IsTrue(board.GetValue(2, 0));
            Assert.AreEqual(6, board.CountAlive());
        }

        [TestMethod]
        public void Test3PixelStrich()
        {
            var board = new Board(20);

            board.SetValue(1, 2, true);
            board.SetValue(2, 2, true);
            board.SetValue(3, 2, true);

            board.CalcNextGen();
            Assert.IsTrue(board.GetValue(2, 1));
            Assert.IsTrue(board.GetValue(2, 2));
            Assert.IsTrue(board.GetValue(2, 3));
            Assert.AreEqual(3, board.CountAlive());
        }

        [TestMethod]
        public void Test3PixelStrichEcke()
        {
            var board = new Board(20);

            board.SetValue(0, 0, true);
            board.SetValue(1, 0, true);
            board.SetValue(2, 0, true);

            board.CalcNextGen();
            Assert.IsTrue(board.GetValue(1, 0));
            Assert.IsTrue(board.GetValue(1, 1));
            Assert.AreEqual(2, board.CountAlive());
        }

        [TestMethod]
        public void TestR()
        {
            var board = new Board(20);

            board.SetValue(1, 1, true);
            board.SetValue(1, 2, true);
            board.SetValue(2, 1, true);
            board.SetValue(2, 3, true);
            board.SetValue(3, 1, true);
            board.SetValue(3, 2, true);
            board.SetValue(4, 1, true);
            board.SetValue(4, 3, true);

            board.CalcNextGen();
            Assert.IsTrue(board.GetValue(1, 1));
            Assert.IsTrue(board.GetValue(1, 2));
            Assert.IsTrue(board.GetValue(2, 0));
            Assert.IsTrue(board.GetValue(3, 0));
            Assert.IsTrue(board.GetValue(2, 3));
            Assert.IsTrue(board.GetValue(3, 3));
            Assert.IsTrue(board.GetValue(3, 1));
            Assert.IsTrue(board.GetValue(4, 1));
            Assert.AreEqual(8, board.CountAlive());
        }

        [TestMethod]
        public void TestREcke()
        {
            var board = new Board(20);

            board.SetValue(0, 0, true);
            board.SetValue(0, 1, true);
            board.SetValue(1, 0, true);
            board.SetValue(1, 2, true);
            board.SetValue(2, 0, true);
            board.SetValue(2, 1, true);
            board.SetValue(3, 0, true);
            board.SetValue(3, 2, true);

            board.CalcNextGen();
            Assert.IsTrue(board.GetValue(0, 0));
            Assert.IsTrue(board.GetValue(0, 1));
            Assert.IsTrue(board.GetValue(1, 2));
            Assert.IsTrue(board.GetValue(2, 2));
            Assert.IsTrue(board.GetValue(2, 0));
            Assert.IsTrue(board.GetValue(3, 0));
            Assert.AreEqual(6, board.CountAlive());
        }

        [TestMethod]
        public void TestL()
        {
            var board = new Board(20);

            board.SetValue(1, 1, true);
            board.SetValue(2, 1, true);
            board.SetValue(3, 1, true);
            board.SetValue(4, 1, true);
            board.SetValue(4, 2, true);
            board.SetValue(4, 3, true);

            board.CalcNextGen();
            Assert.IsTrue(board.GetValue(2, 0));
            Assert.IsTrue(board.GetValue(2, 1));
            Assert.IsTrue(board.GetValue(2, 2));
            Assert.IsTrue(board.GetValue(3, 0));
            Assert.IsTrue(board.GetValue(3, 1));
            Assert.IsTrue(board.GetValue(4, 1));
            Assert.IsTrue(board.GetValue(4, 2));
            Assert.IsTrue(board.GetValue(5, 2));
            Assert.AreEqual(8, board.CountAlive());
        }

        [TestMethod]
        public void TestLEcke()
        {
            var board = new Board(20);

            board.SetValue(0, 0, true);
            board.SetValue(1, 0, true);
            board.SetValue(2, 0, true);
            board.SetValue(3, 0, true);
            board.SetValue(3, 1, true);
            board.SetValue(3, 2, true);

            board.CalcNextGen();
            Assert.IsTrue(board.GetValue(1, 0));
            Assert.IsTrue(board.GetValue(1, 1));
            Assert.IsTrue(board.GetValue(2, 0));
            Assert.IsTrue(board.GetValue(3, 0));
            Assert.IsTrue(board.GetValue(3, 1));
            Assert.IsTrue(board.GetValue(4, 1));
            Assert.AreEqual(6, board.CountAlive());
        }

        [TestMethod]
        public void Test2x2Quadrat()
        {
            var board = new Board(20);

            board.SetValue(0, 0, true);
            board.SetValue(0, 1, true);
            board.SetValue(1, 1, true);
            board.SetValue(1, 0, true);

            board.CalcNextGen();
            Assert.IsTrue(board.GetValue(0, 0));
            Assert.IsTrue(board.GetValue(0, 1));
            Assert.IsTrue(board.GetValue(1, 1));
            Assert.IsTrue(board.GetValue(1, 0));
            Assert.AreEqual(4, board.CountAlive());
        }
    }
}
