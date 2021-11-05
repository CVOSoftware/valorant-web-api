using System;
using System.Collections.Generic;
using System.Text;

using CVOSoftware.ValorantAPI.Endpoint;

namespace CVOSoftware.ValorantAPI
{
    public sealed class ClientValorantAPI
    {
        public ClientValorantAPI()
        {

        }

        #region Endpoints

        public IContentEndpoint Content { get; }

        public IMatchEndpoint Match { get; }

        public IRankedEndpoint Ranked { get; }

        public IStatusEndpoint Status { get; }

        #endregion
    }
}