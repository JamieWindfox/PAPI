using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Serialization
{
    class lockObject
    {
        public int count = 0;
    }

    public class LockManager
    {
        // Code source: https://www.codeproject.com/Tips/1190802/File-Locking-in-a-Multi-Threaded-Environment

        static ConcurrentDictionary<string, lockObject> _locks = new ConcurrentDictionary<string, lockObject>();
        private static lockObject GetLock(string filename)
        {
            lockObject lockObj = null;
            if (_locks.TryGetValue(filename.ToLower(), out lockObj))
            {
                lockObj.count++;
                return lockObj;
            }
            else
            {
                lockObj = new lockObject();
                _locks.TryAdd(filename.ToLower(), lockObj);
                lockObj.count++;
                return lockObj;
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public static void GetLock(string filename, Action action)
        {
            lock (GetLock(filename))
            {
                action();
                Unlock(filename);
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        private static void Unlock(string filename)
        {
            lockObject lockObj = null;
            if (_locks.TryGetValue(filename.ToLower(), out lockObj))
            {
                lockObj.count--;
                if (lockObj.count == 0) _locks.TryRemove(filename.ToLower(), out lockObj);
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
