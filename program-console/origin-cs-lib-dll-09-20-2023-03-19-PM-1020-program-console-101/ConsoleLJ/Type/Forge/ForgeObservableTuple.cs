using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    using System.IO;

    public partial class ConsoleLJ
    {
        public static Tuple<String[], String[]> ForgeObservableTuple__FILE_DIRECTORY(String item_DIRECTORY)
        {
            Tuple<String[], String[]> tupleResult = default;

            Tuple<String[], String[]> tuple;

            String[] fileArray, directoryArray;

            if (Directory.Exists(ArchitectureZeroTen.InputDirectory))
            {
                directoryArray = ConsoleLJFolderSetSurface(0, ArchitectureZeroTen.InputDirectory);
            }
            else
            {
                directoryArray = ConsoleLJFolderSetSurface(0, item_DIRECTORY);
            }

            fileArray = ConsoleLJFileSetSurface(0, directoryArray);

            tuple = new Tuple<String[], String[]>(fileArray, directoryArray);

            tupleResult = tuple;

            return tupleResult;
        }
    }
}
