# UniCorefx

CorefxやReference Sourceからコピペしてきて、Unityでも動けばいいですねライブラリ。

コンパイルはできる(動くとは言っていない)

- https://github.com/Microsoft/referencesource
- https://github.com/dotnet/corefx

## Classes

- System
  - Action&lt;T1, T2, T3, T4, T5, T6, T7, T8>
  - Action&lt;T1, T2, T3, T4, T5, T6, T7>
  - Action&lt;T1, T2, T3, T4, T5, T6>
  - Action&lt;T1, T2, T3, T4, T5>
  - Func&lt;T1, T2, T3, T4, T5, T6, T7, T8, TResult>
  - Func&lt;T1, T2, T3, T4, T5, T6, T7, TResult>
  - Func&lt;T1, T2, T3, T4, T5, T6, TResult>
  - Func&lt;T1, T2, T3, T4, T5, TResult>
  - Lazy&lt;T>
  - Tuple&lt;T1, T2, T3, T4, T5, T6, T7, TRest>
  - Tuple&lt;T1, T2, T3, T4, T5, T6, T7>
  - Tuple&lt;T1, T2, T3, T4, T5, T6>
  - Tuple&lt;T1, T2, T3, T4, T5>
  - Tuple&lt;T1, T2, T3, T4>
  - Tuple&lt;T1, T2, T3>
  - Tuple&lt;T1, T2>
  - Tuple&lt;T>
  - Tuple
  - Collections
    - StructualComparer
    - StructualComparisons
    - StructualEqualityComparer
    - Concurrent
      - ConcurrentDictionary&lt;TKey, TValue>
      - ConcurrentQueue&lt;T>
      - ConcurrentStack&lt;T>
      - OrderablePartitioner&lt;TSource>
      - Partitioner
    - Generic
      - IReadOnlyCollection&lt;T>
      - IReadOnlyDictionary&lt;TKey, TValue>
      - IReadOnlyList&lt;T>
      - ISet&lt;T>
  - Threading
    - ThreadLocal&lt;T>
    - Volatile
    - SpinWait


# Extensions
- System.Stopwatch.Restart()
