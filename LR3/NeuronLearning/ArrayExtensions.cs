using System.Collections.Generic;

namespace NeuronLearning
{
    public static class ArrayExtensions<T>
    {
        public static T[] FromThreeDimensionsToOne(T[,,] threeDimensionalArray, int thirdDimensionIndex)
        {
            var arr = new List<T>();

            for (var i = 0; i < threeDimensionalArray.GetLength(1); i++)
            {
                for (var j = 0; j < threeDimensionalArray.GetLength(2); j++)
                {
                    arr.Add(threeDimensionalArray[thirdDimensionIndex, i, j]);
                }
            }

            return arr.ToArray();
        }
    }
}
