using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class TempChecker
    {
        private int[] _occurrences = new int[111];  // Array of 0s at indices 0..110
        private int _maxOccurrences;
        private int? _mode;

        // For mean
        private int _numberOfReadings;
        private int _totalSum;
        private double? _mean;  // Mean should be double

        // For min and max
        private int? _minTemp;
        private int? _maxTemp;

        public void Insert(int temperature)
        {
            // For mode
            _occurrences[temperature]++;
            if (_occurrences[temperature] > _maxOccurrences)
            {
                _mode = temperature;
                _maxOccurrences = _occurrences[temperature];
            }

            // For mean
            _numberOfReadings++;
            _totalSum += temperature;
            _mean = (double)_totalSum / _numberOfReadings;

            // For min and max
            if (_maxTemp == null || temperature > _maxTemp)
            {
                _maxTemp = temperature;
            }

            if (_minTemp == null || temperature < _minTemp)
            {
                _minTemp = temperature;
            }
        }

        public int? GetMax()
        {
            return _maxTemp;
        }

        public int? GetMin()
        {
            return _minTemp;
        }

        public double? GetMean()
        {
            return _mean;
        }

        public int? GetMode()
        {
            return _mode;
        }

    }
}
