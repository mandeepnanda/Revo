﻿using System;

namespace Revo.Infrastructure.Events.Async
{
    public class AsyncEventPipelineConfiguration : IAsyncEventPipelineConfiguration
    {
        public AsyncEventPipelineConfiguration()
        {
        }

        public int AsyncProcessAttemptCount { get; set; } = 3;
        public TimeSpan AsyncRescheduleDelayAfterSyncProcessFailure { get; set; } = TimeSpan.FromMinutes(1);
        public TimeSpan AsyncProcessRetryTimeout { get; set; } = TimeSpan.FromMilliseconds(500);
        public int AsyncProcessRetryTimeoutMultiplier { get; set; } = 6;

        public int SyncProcessAttemptCount { get; set; } = 3;
        public TimeSpan SyncProcessRetryTimeout { get; set; } = TimeSpan.FromMilliseconds(500);
        public int SyncProcessRetryTimeoutMultiplier { get; set; } = 4;
    }
}
