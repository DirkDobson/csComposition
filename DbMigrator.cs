using System;

namespace Composition
{
  public class DbMigrator
  {
    private readonly Logger _logger;
    public DbMigrator(Logger _logger)
    {
        _logger = logger;
    }
    
    public void Migrate()
    {
      _logger.Log("We are migrating");
    }
  }
}
