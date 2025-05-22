using System;
using System.Collections.Generic;
using System.Linq;
using FastStream;
using FastStream.Extensions;

namespace FileManager {
    public class DateHistory {
        private List<DateTime> _dates = new List<DateTime>();
        public IList<DateTime> Dates => _dates.AsReadOnly();

        //Methods
        public DateTime this[int index] {
            get => _dates[index];
            set {
                _dates[index] = value;

                SortList();
            }
        }

        public void Add(DateTime dateTime) {
            _dates.Add(dateTime);

            SortList();
        }
        public void RemoveAt(int index) {
            _dates.RemoveAt(index);
        }
        public void Replace(int index, DateTime dateTime) {
            _dates[index] = dateTime;

            SortList();
        }
        public bool Exists(DateTime dateTime) {
            return _dates.Exists(x => x.TrimMilliseconds() == dateTime.TrimMilliseconds());
        }

        private void SortList() {
            _dates = _dates.OrderBy(x => x).ToList();
        }

        //Serialization
        public void Serialize(FastBinaryWriter writer) {
            writer.Write(_dates.Count);

            foreach (var date in _dates) {
                writer.Write(date);
            }
        }
        public static DateHistory Deserialize(FastBinaryReader reader) {
            int count = reader.ReadInt32();

            DateHistory history = new DateHistory();
            while (count > 0) {
                history._dates.Add(reader.ReadDateTime());

                count--;
            }

            return history;
        }
    }
}
