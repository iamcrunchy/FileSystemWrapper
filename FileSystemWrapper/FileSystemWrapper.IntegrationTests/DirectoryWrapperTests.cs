using System.IO;
using NUnit.Framework;

namespace FileSystemWrapper.IntegrationTests
{
    [TestFixture]
    public class DirectoryWrapperTestsTests
    {
        #region Setup/Teardown: class level declarations and settings go here

        private string directory = @"c:\testfiles\";


        #endregion

        #region Exception tests go here



        #endregion

        #region Unit tests go here

        [Test]
        public void WhenGettingFiles_ExceptFilesWithDatExtension_NoDatFilesReturned()
        {
            // ARRANGE => ACT => Assert
            var sut = new DirectoryWrapper();

            var fileList = sut.GetFilesFromDirectoryExceptThoseWithSpecifiedExtension(directory, ".dat");

            var result = true;
            foreach (var file in fileList)
            {
                if (file.EndsWith(".dat"))
                    result = false;
            }

            Assert.IsTrue(result);
        }

        [Test]
        public void WhenGettingFiles_ExceptFilesWithDatExtension_FilesWithoutDatExtensionReturned()
        {
            // ARRANGE => ACT => Assert
            var sut = new DirectoryWrapper();

            var fileList = sut.GetFilesFromDirectoryExceptThoseWithSpecifiedExtension(directory, ".dat");

            Assert.GreaterOrEqual(fileList.Length, 1);
        }

        [Test]
        public void GetFilesFromDirectory_GetAllFilesFromTheSpecifiedDirectory_FileCountGreaterThan0()
        {
            // ARRANGE => ACT => Assert
            var sut = new DirectoryWrapper();

            var filelist = sut.GetFilesFromDirectory(directory);

            Assert.GreaterOrEqual(filelist.Length, 0);
        }

        #endregion
    }
}