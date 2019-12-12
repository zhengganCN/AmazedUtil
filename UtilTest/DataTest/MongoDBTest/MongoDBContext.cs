﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using Util.Data.UOW.MongoDBUOW;

namespace UtilTest.DataTest.MongoDBTest
{
    class MongoDBContext : DbContext
    {
        public override MongoClient MongoClientConfiguration()
        {
            return new MongoClient("");
        }
        public override IMongoDatabase MongoDatabaseConfiguration()
        {
            return MongoClientConfiguration().GetDatabase("");
        }
    }
}
