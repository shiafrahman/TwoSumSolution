using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoSumLib;

namespace TwoSumTests
{
    public class SolverTests
    {
        private readonly Solver _solver = new();

        [Fact]
        public void TwoSum_NormalCase_ReturnsIndices()
        {
            var result = _solver.TwoSum(new[] { 2, 7, 11, 15 }, 9);
            Assert.Equal(new[] { 0, 1 }, result);
        }

        [Fact]
        public void TwoSum_EdgeCase_EmptyArray_ReturnsEmpty()
        {
            var result = _solver.TwoSum(Array.Empty<int>(), 10);
            Assert.Empty(result);
        }

        [Fact]
        public void TwoSum_Duplicates_ReturnsCorrectIndices()
        {
            var result = _solver.TwoSum(new[] { 3, 3, 4 }, 6);
            Assert.Equal(new[] { 0, 1 }, result);
        }

        [Fact]
        public void TwoSum_NoSolution_ReturnsEmpty()
        {
            var result = _solver.TwoSum(new[] { 1, 2, 3 }, 7);
            Assert.Empty(result);
        }
    }
}
