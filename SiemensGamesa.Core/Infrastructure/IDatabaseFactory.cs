using SiemensGamesa.Core.Entity;
using System;

namespace SiemensGamesa.Core.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        Context Get();
    }
}
