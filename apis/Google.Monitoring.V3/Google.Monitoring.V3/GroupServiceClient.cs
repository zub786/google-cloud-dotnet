// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api;
using Google.Api.Gax;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Monitoring.V3
{

    /// <summary>
    /// Extension methods to assist with using <see cref="GroupServiceClient"/>.
    /// </summary>
    public static partial class GroupServiceExtensions
    {
        /// <summary>
        /// Wrap a GRPC GroupService client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="GroupServiceSettings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="GroupServiceClient"/> that wraps the specified GRPC client.</returns>
        public static GroupServiceClient ToClient(
            this GroupService.GroupServiceClient grpcClient,
            GroupServiceSettings settings = null
        ) => new GroupServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a GroupService wrapper.
    /// </summary>
    public sealed partial class GroupServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="GroupServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default GroupServiceSettings.</returns>
        public static GroupServiceSettings GetDefault() => new GroupServiceSettings();

        /// <summary>
        /// Constructs a new GroupServiceSettings object with default settings.
        /// </summary>
        public GroupServiceSettings() { }

        private GroupServiceSettings(GroupServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListGroupsSettings = existing.ListGroupsSettings?.Clone();
            GetGroupSettings = existing.GetGroupSettings?.Clone();
            CreateGroupSettings = existing.CreateGroupSettings?.Clone();
            UpdateGroupSettings = existing.UpdateGroupSettings?.Clone();
            DeleteGroupSettings = existing.DeleteGroupSettings?.Clone();
            ListGroupMembersSettings = existing.ListGroupMembersSettings?.Clone();
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="GroupServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="GroupServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="GroupServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" retry backoff for <see cref="GroupServiceClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="GroupServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(100),
            DelayMultiplier = 1.3,
            MaxDelay = TimeSpan.FromMilliseconds(60000),
        };

        /// <summary>
        /// "Default" timeout backoff for <see cref="GroupServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" timeout backoff for <see cref="GroupServiceClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="GroupServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(20000),
            DelayMultiplier = 1.0,
            MaxDelay = TimeSpan.FromMilliseconds(20000),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="GroupServiceClient.ListGroups"/> and <see cref="GroupServiceClient.ListGroupsAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="GroupServiceClient.ListGroups"/> and
        /// <see cref="GroupServiceClient.ListGroupsAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListGroupsSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="GroupServiceClient.GetGroup"/> and <see cref="GroupServiceClient.GetGroupAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="GroupServiceClient.GetGroup"/> and
        /// <see cref="GroupServiceClient.GetGroupAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetGroupSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="GroupServiceClient.CreateGroup"/> and <see cref="GroupServiceClient.CreateGroupAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="GroupServiceClient.CreateGroup"/> and
        /// <see cref="GroupServiceClient.CreateGroupAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CreateGroupSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="GroupServiceClient.UpdateGroup"/> and <see cref="GroupServiceClient.UpdateGroupAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="GroupServiceClient.UpdateGroup"/> and
        /// <see cref="GroupServiceClient.UpdateGroupAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings UpdateGroupSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="GroupServiceClient.DeleteGroup"/> and <see cref="GroupServiceClient.DeleteGroupAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="GroupServiceClient.DeleteGroup"/> and
        /// <see cref="GroupServiceClient.DeleteGroupAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteGroupSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="GroupServiceClient.ListGroupMembers"/> and <see cref="GroupServiceClient.ListGroupMembersAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="GroupServiceClient.ListGroupMembers"/> and
        /// <see cref="GroupServiceClient.ListGroupMembersAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListGroupMembersSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };


        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of GroupService settings.</returns>
        public GroupServiceSettings Clone() => new GroupServiceSettings(this);
    }

    /// <summary>
    /// GroupService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class GroupServiceClient
    {
        /// <summary>
        /// The default endpoint for the GroupService service, which is a host of "monitoring.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("monitoring.googleapis.com", 443);

        /// <summary>
        /// The default GroupService scopes
        /// </summary>
        /// <remarks>
        /// The default GroupService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform"
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        /// <summary>
        /// Path template for a project resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate ProjectTemplate { get; } = new PathTemplate("projects/{project}");

        /// <summary>
        /// Creates a project resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <returns>The full project resource name.</returns>
        public static string FormatProjectName(string projectId) => ProjectTemplate.Expand(projectId);

        /// <summary>
        /// Path template for a group resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>group</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate GroupTemplate { get; } = new PathTemplate("projects/{project}/groups/{group}");

        /// <summary>
        /// Creates a group resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <returns>The full group resource name.</returns>
        public static string FormatGroupName(string projectId, string groupId) => GroupTemplate.Expand(projectId, groupId);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="GroupServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GroupServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="GroupServiceClient"/>.</returns>
        public static async Task<GroupServiceClient> CreateAsync(ServiceEndpoint endpoint = null, GroupServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="GroupServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GroupServiceSettings"/>.</param>
        /// <returns>The created <see cref="GroupServiceClient"/>.</returns>
        public static GroupServiceClient Create(ServiceEndpoint endpoint = null, GroupServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="GroupServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GroupServiceSettings"/>.</param>
        /// <returns>The created <see cref="GroupServiceClient"/>.</returns>
        public static GroupServiceClient Create(Channel channel, GroupServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            GroupService.GroupServiceClient grpcClient = new GroupService.GroupServiceClient(channel);
            return new GroupServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, GroupServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, GroupServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, GroupServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, GroupServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying GRPC GroupService client.
        /// </summary>
        public virtual GroupService.GroupServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="childrenOfGroup"></param>
        /// <param name="ancestorsOfGroup"></param>
        /// <param name="descendantsOfGroup"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of Group resources.</returns>
        public virtual IPagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(
            string name,
            string childrenOfGroup,
            string ancestorsOfGroup,
            string descendantsOfGroup,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="childrenOfGroup"></param>
        /// <param name="ancestorsOfGroup"></param>
        /// <param name="descendantsOfGroup"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of Group resources.</returns>
        public virtual IPagedEnumerable<ListGroupsResponse, Group> ListGroups(
            string name,
            string childrenOfGroup,
            string ancestorsOfGroup,
            string descendantsOfGroup,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Group> GetGroupAsync(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Group> GetGroupAsync(
            string name,
            CancellationToken cancellationToken) => GetGroupAsync(
                name,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group GetGroup(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="group"></param>
        /// <param name="validateOnly"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Group> CreateGroupAsync(
            string name,
            Group group,
            bool validateOnly,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="group"></param>
        /// <param name="validateOnly"></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Group> CreateGroupAsync(
            string name,
            Group group,
            bool validateOnly,
            CancellationToken cancellationToken) => CreateGroupAsync(
                name,
                group,
                validateOnly,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="group"></param>
        /// <param name="validateOnly"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group CreateGroup(
            string name,
            Group group,
            bool validateOnly,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="group"></param>
        /// <param name="validateOnly"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Group> UpdateGroupAsync(
            Group group,
            bool validateOnly,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="group"></param>
        /// <param name="validateOnly"></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Group> UpdateGroupAsync(
            Group group,
            bool validateOnly,
            CancellationToken cancellationToken) => UpdateGroupAsync(
                group,
                validateOnly,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        ///
        /// </summary>
        /// <param name="group"></param>
        /// <param name="validateOnly"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group UpdateGroup(
            Group group,
            bool validateOnly,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteGroupAsync(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteGroupAsync(
            string name,
            CancellationToken cancellationToken) => DeleteGroupAsync(
                name,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGroup(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filter"></param>
        /// <param name="interval"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of MonitoredResource resources.</returns>
        public virtual IPagedAsyncEnumerable<ListGroupMembersResponse, MonitoredResource> ListGroupMembersAsync(
            string name,
            string filter,
            TimeInterval interval,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filter"></param>
        /// <param name="interval"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of MonitoredResource resources.</returns>
        public virtual IPagedEnumerable<ListGroupMembersResponse, MonitoredResource> ListGroupMembers(
            string name,
            string filter,
            TimeInterval interval,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class GroupServiceClientImpl : GroupServiceClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<ListGroupsRequest, ListGroupsResponse> _callListGroups;
        private readonly ApiCall<GetGroupRequest, Group> _callGetGroup;
        private readonly ApiCall<CreateGroupRequest, Group> _callCreateGroup;
        private readonly ApiCall<UpdateGroupRequest, Group> _callUpdateGroup;
        private readonly ApiCall<DeleteGroupRequest, Empty> _callDeleteGroup;
        private readonly ApiCall<ListGroupMembersRequest, ListGroupMembersResponse> _callListGroupMembers;

        public GroupServiceClientImpl(GroupService.GroupServiceClient grpcClient, GroupServiceSettings settings)
        {
            this.GrpcClient = grpcClient;
            GroupServiceSettings effectiveSettings = settings ?? GroupServiceSettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callListGroups = _clientHelper.BuildApiCall<ListGroupsRequest, ListGroupsResponse>(
                GrpcClient.ListGroupsAsync, GrpcClient.ListGroups, effectiveSettings.ListGroupsSettings);
            _callGetGroup = _clientHelper.BuildApiCall<GetGroupRequest, Group>(
                GrpcClient.GetGroupAsync, GrpcClient.GetGroup, effectiveSettings.GetGroupSettings);
            _callCreateGroup = _clientHelper.BuildApiCall<CreateGroupRequest, Group>(
                GrpcClient.CreateGroupAsync, GrpcClient.CreateGroup, effectiveSettings.CreateGroupSettings);
            _callUpdateGroup = _clientHelper.BuildApiCall<UpdateGroupRequest, Group>(
                GrpcClient.UpdateGroupAsync, GrpcClient.UpdateGroup, effectiveSettings.UpdateGroupSettings);
            _callDeleteGroup = _clientHelper.BuildApiCall<DeleteGroupRequest, Empty>(
                GrpcClient.DeleteGroupAsync, GrpcClient.DeleteGroup, effectiveSettings.DeleteGroupSettings);
            _callListGroupMembers = _clientHelper.BuildApiCall<ListGroupMembersRequest, ListGroupMembersResponse>(
                GrpcClient.ListGroupMembersAsync, GrpcClient.ListGroupMembers, effectiveSettings.ListGroupMembersSettings);
        }

        public override GroupService.GroupServiceClient GrpcClient { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="childrenOfGroup"></param>
        /// <param name="ancestorsOfGroup"></param>
        /// <param name="descendantsOfGroup"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of Group resources.</returns>
        public override IPagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(
            string name,
            string childrenOfGroup,
            string ancestorsOfGroup,
            string descendantsOfGroup,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedAsyncEnumerable<ListGroupsRequest, ListGroupsResponse, Group>(
                _callListGroups,
                new ListGroupsRequest
                {
                    Name = name,
                    ChildrenOfGroup = childrenOfGroup,
                    AncestorsOfGroup = ancestorsOfGroup,
                    DescendantsOfGroup = descendantsOfGroup,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="childrenOfGroup"></param>
        /// <param name="ancestorsOfGroup"></param>
        /// <param name="descendantsOfGroup"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of Group resources.</returns>
        public override IPagedEnumerable<ListGroupsResponse, Group> ListGroups(
            string name,
            string childrenOfGroup,
            string ancestorsOfGroup,
            string descendantsOfGroup,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedEnumerable<ListGroupsRequest, ListGroupsResponse, Group>(
                _callListGroups,
                new ListGroupsRequest
                {
                    Name = name,
                    ChildrenOfGroup = childrenOfGroup,
                    AncestorsOfGroup = ancestorsOfGroup,
                    DescendantsOfGroup = descendantsOfGroup,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<Group> GetGroupAsync(
            string name,
            CallSettings callSettings = null) => _callGetGroup.Async(
                new GetGroupRequest
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Group GetGroup(
            string name,
            CallSettings callSettings = null) => _callGetGroup.Sync(
                new GetGroupRequest
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="group"></param>
        /// <param name="validateOnly"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<Group> CreateGroupAsync(
            string name,
            Group group,
            bool validateOnly,
            CallSettings callSettings = null) => _callCreateGroup.Async(
                new CreateGroupRequest
                {
                    Name = name,
                    Group = group,
                    ValidateOnly = validateOnly,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="group"></param>
        /// <param name="validateOnly"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Group CreateGroup(
            string name,
            Group group,
            bool validateOnly,
            CallSettings callSettings = null) => _callCreateGroup.Sync(
                new CreateGroupRequest
                {
                    Name = name,
                    Group = group,
                    ValidateOnly = validateOnly,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="group"></param>
        /// <param name="validateOnly"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<Group> UpdateGroupAsync(
            Group group,
            bool validateOnly,
            CallSettings callSettings = null) => _callUpdateGroup.Async(
                new UpdateGroupRequest
                {
                    Group = group,
                    ValidateOnly = validateOnly,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="group"></param>
        /// <param name="validateOnly"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Group UpdateGroup(
            Group group,
            bool validateOnly,
            CallSettings callSettings = null) => _callUpdateGroup.Sync(
                new UpdateGroupRequest
                {
                    Group = group,
                    ValidateOnly = validateOnly,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task DeleteGroupAsync(
            string name,
            CallSettings callSettings = null) => _callDeleteGroup.Async(
                new DeleteGroupRequest
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteGroup(
            string name,
            CallSettings callSettings = null) => _callDeleteGroup.Sync(
                new DeleteGroupRequest
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filter"></param>
        /// <param name="interval"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of MonitoredResource resources.</returns>
        public override IPagedAsyncEnumerable<ListGroupMembersResponse, MonitoredResource> ListGroupMembersAsync(
            string name,
            string filter,
            TimeInterval interval,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedAsyncEnumerable<ListGroupMembersRequest, ListGroupMembersResponse, MonitoredResource>(
                _callListGroupMembers,
                new ListGroupMembersRequest
                {
                    Name = name,
                    Filter = filter,
                    Interval = interval,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filter"></param>
        /// <param name="interval"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of MonitoredResource resources.</returns>
        public override IPagedEnumerable<ListGroupMembersResponse, MonitoredResource> ListGroupMembers(
            string name,
            string filter,
            TimeInterval interval,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedEnumerable<ListGroupMembersRequest, ListGroupMembersResponse, MonitoredResource>(
                _callListGroupMembers,
                new ListGroupMembersRequest
                {
                    Name = name,
                    Filter = filter,
                    Interval = interval,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

    }

    // Partial classes to enable page-streaming

    public partial class ListGroupsRequest : IPageRequest { }
    public partial class ListGroupsResponse : IPageResponse<Group>
    {
        public IEnumerator<Group> GetEnumerator() => Group.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGroupMembersRequest : IPageRequest { }
    public partial class ListGroupMembersResponse : IPageResponse<MonitoredResource>
    {
        public IEnumerator<MonitoredResource> GetEnumerator() => Members.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}