using eRecruiter.Api.Responses;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace eRecruiter.Api.Client
{
    public class ApiTokenCache
    {
        private IDictionary<int, ApiTokenResponse> _cachedTokens = new ConcurrentDictionary<int, ApiTokenResponse>();

        public void AddToken(int mandatorId, ApiTokenResponse tokenResponse)
        {
            _cachedTokens[mandatorId] = tokenResponse;
        }

        public bool HasCachedToken(int mandatorId)
        {
            return _cachedTokens.ContainsKey(mandatorId);
        }

        public ApiTokenResponse GetCachedToken(int mandatorId)
        {
            if (HasCachedToken(mandatorId))
                return _cachedTokens[mandatorId];
            return null;
        }

        public void Clear()
        {
            _cachedTokens = new ConcurrentDictionary<int, ApiTokenResponse>();
        }

        public void Clear(int mandatorId)
        {
            if (_cachedTokens != null && _cachedTokens.ContainsKey(mandatorId))
                _cachedTokens.Remove(mandatorId);
        }
    }
}
