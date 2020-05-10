using AmazedMP3InfoReader;
using NUnit.Framework;
using System.IO;

namespace NUnitTestMP3InfoReader
{
    public class MP3ReaderTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(@"E:\QMDownload\Ayo97 _ ��˼�� - ��л��������.mp3")]
        [TestCase(@"E:\QMDownload\����� - ��Ͳ�Ҫ������.mp3")]
        [TestCase(@"E:\QMDownload\����� - ��Ͳ�Ҫ������(1).mp3")]
        public void ID3V1Test(string path)
        {
            MP3Reader mP3Reader = new MP3Reader();
            var iD3V1 = mP3Reader.GetMP3_ID3V1(path);
            Assert.IsNotNull(iD3V1);
        }

        [Test]
        [TestCase(@"E:\QMDownload\Ayo97 _ ��˼�� - ��л��������.mp3")]
        public void ID3V2Test(string path)
        {
            MP3Reader mP3Reader = new MP3Reader();
            var iD3V2 = mP3Reader.GetMP3_ID3V2(path);
            Assert.IsNotNull(iD3V2);
        }

        [Test]
        [TestCase(@"E:\QMDownload\Ayo97 _ ��˼�� - ��л��������.mp3")]
        [TestCase(@"E:\QMDownload\����� - ��Ͳ�Ҫ������.mp3")]
        [TestCase(@"E:\QMDownload\����� - ��Ͳ�Ҫ������(1).mp3")]
        public void MP3InfoTest(string path)
        {
            MP3Reader mP3Reader = new MP3Reader();
            var iD3V2 = mP3Reader.GetMP3Info(path);
            Assert.IsNotNull(iD3V2);
        }

    }
}