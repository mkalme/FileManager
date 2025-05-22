using System;
using System.Collections.Generic;
using FastStream;
using FastStream.Extensions;

namespace GUI {
    public class KeyHistory {
        private List<DateTime> _changedDates = new List<DateTime>();
        public IList<DateTime> ChangedDates => _changedDates.AsReadOnly();

        public void Add(DateTime date) {
            _changedDates.Add(date);
        }
        public DateTime GetLastDate() {
            return _changedDates[_changedDates.Count - 1];
        }

        public static KeyHistory Deserialize(FastBinaryReader reader) {
            KeyHistory history = new KeyHistory();

            int count = reader.ReadInt32();
            while(count > 0){
                history._changedDates.Add(reader.ReadDateTime());

                count--;
            }

            return history;
        }
        public void Serialize(FastBinaryWriter writer) {
            writer.Write(ChangedDates.Count);
            
            foreach (var date in ChangedDates) {
                writer.Write(date);
            }
        }
    }
}
