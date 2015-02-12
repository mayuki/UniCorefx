# UniCorefx

CorefxやReference Sourceからコピペしてきて、Unityでも動けばいいですねライブラリ。

コンパイルはできる(動くとは言っていない)

- https://github.com/Microsoft/referencesource
- https://github.com/dotnet/corefx

## Classes

- System
  - Action<T1, T2, T3, T4, T5, T6, T7, T8>
  - Action<T1, T2, T3, T4, T5, T6, T7>
  - Action<T1, T2, T3, T4, T5, T6>
  - Action<T1, T2, T3, T4, T5>
  - Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
  - Func<T1, T2, T3, T4, T5, T6, T7, TResult>
  - Func<T1, T2, T3, T4, T5, T6, TResult>
  - Func<T1, T2, T3, T4, T5, TResult>
  - Lazy<T>
  - Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>
  - Tuple<T1, T2, T3, T4, T5, T6, T7>
  - Tuple<T1, T2, T3, T4, T5, T6>
  - Tuple<T1, T2, T3, T4, T5>
  - Tuple<T1, T2, T3, T4>
  - Tuple<T1, T2, T3>
  - Tuple<T1, T2>
  - Tuple<T1>
  - Tuple
  - Collections
    - StructualComparer
    - StructualComparisons
    - StructualEqualityComparer
    - Concurrent
      - ConcurrentDictionary<TKey, TValue>
      - ConcurrentQueue<T>
      - ConcurrentStack<T>
      - OrderablePartitioner<TSource>
      - Partitioner
    - Generic
      - IReadOnlyCollection<T>
      - IReadOnlyDictionary<TKey, TValue>
      - IReadOnlyList<T>
      - ISet<T>
  - Threading
    - ThreadLocal<T>
    - Volatile
    - SpinWait


# Extensions
- System.Stopwatch.Restart()