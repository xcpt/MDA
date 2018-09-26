# MDA(devloping)
**Message Driven Architecture**

旨在让开发一个低延迟、高并发、高可用、基于消息驱动的响应式系统变得无比的简单。

**最简单、最本质的开发模式**
- 接受哪些类型的消息 -- 命令/事件
- 发出哪些类型的消息 -- 命令/事件

这就是你需要做的工作，就是这么简单，其他的事情，不用管，框架帮你搞定了，让你真正的Domain-Driven Design！！！

**特性**
1. 低延迟

   运用Event souring技术使整个业务处理部分完全运行在内存中。

2. 高并发

   基于事件驱动，使用单线程技术处理整个业务逻辑，从源头解决并发问题。

3. 高可用

   通过并行复制原始事件源数据到远程机器，实现实时同步领域状态，当本机业务处理器宕机时，实现秒级切换。这不仅比基于最近快照副本重放最新事件更快，而且也解决了单点故障的问题。

目前正在开发中...
