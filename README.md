# Concurrent and Parallel in C#


## Reference:


Riccardo Terrell - Concurrency in .NET_ Modern patterns of concurrent and parallel programming-Manning (2018)


## Content


### Sequential programming


Sequential programming is the act of accomplishing things in steps

<p align="center">
  <img src="https://user-images.githubusercontent.com/41349878/149008386-45dc2979-3d86-4678-8c44-293ae3505af6.png?raw=true">
</p>


### Concurrent programming


Concurrent programming runs multiple tasks at the same time. Concurrency describes the ability to run several programs or multiple parts of a program
at the same time. Using concurrency within an application provides actual multitasking, dividing the application into multiple and independent processes that run at the same time (concurrently) in different threads. This can happen either in a single CPU core or in parallel, if multiple CPU cores are available.

Concurrency gives the impression that these threads are running in parallel and that different parts of the program can run simultaneously. But in a single-core environment, the execution of one thread is temporarily paused and switched to another thread.



### Parallel programming


Parallelism is the concept of executing multiple tasks at once concurrently, literally at the same time on different cores, to improve the speed of the application

All parallel programs are concurrent (runs multiple tasks/things at the same time), but not all concurrency is parallel because parallelism requires hardware support (multiple cores)


<p align="center">
  <img src="https://user-images.githubusercontent.com/41349878/149010407-aae2b1fe-59f2-4f45-8588-dc346337cabe.png?raw=true">
</p>


Parallelism can be achieved when a single task is split into multiple independent
subtasks

<p align="center">
  <img src="https://user-images.githubusercontent.com/41349878/149010678-e75751a4-3778-4d39-b655-eb2446819bd3.png?raw=true">
</p>


### Multitasking


Multitasking is the concept of performing multiple tasks over a period of time by executing them concurrently.

Computer multitasking was designed in the days when computers had a single CPU to concurrently perform many tasks while sharing the same computing resources.

Each task has a different shade, indicating that the context switch in a single-core machine gives the illusion that multiple tasks run in parallel, but only one task is processed at a time.

<p align="center">
  <img src="https://user-images.githubusercontent.com/41349878/149011060-66378db1-1807-468b-bfdb-0b0e731ff076.png?raw=true">
</p>


### Multithreading 

Multithreading is an extension of the concept of multitasking, aiming to improve the performance of a program by maximizing and optimizing computer resources. Multithreading is a form of concurrency that uses multiple threads of execution. 

Multithreading differs from multitasking: Unlike multitasking, with multithreading, the threads share resources

Multithreading is hardware-agnostic, which means that it can be performed regardless of the number of cores. Parallel programming is a superset of multithreading. You could use multithreading to parallelize a program by sharing resources in the same process, for example, but you could also parallelize a program by executing the computation in multiple processes or even in different computers. 

Relationship between concurrency, parallelism, multithreading, and multitasking in a single
and a multicore device

<p align="center">
  <img src="https://user-images.githubusercontent.com/41349878/149012012-df3c4963-eecf-4587-99bf-77101a45da5c.png?raw=true">
</p>


Glossary:

**PROCESS** : A **process** is an instance of a program running within a computer system. Each process has one or more threads of execution, and no thread can exist outside a process.

**THREAD** : A **thread** is a unit of computation (an independent set of programming instructions designed to achieve a particular result), which the operating system scheduler independently executes and manages.

**THREADSAFE** : A method is called **threadsafe** when the data and state don’t get corrupted if two or more threads attempt to
access and modify the data or state at the same time.


