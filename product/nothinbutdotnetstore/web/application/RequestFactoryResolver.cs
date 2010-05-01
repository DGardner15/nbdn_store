using System;
using System.Collections.Generic;
using nothinbutdotnetstore.infrastructure;
using nothinbutdotnetstore.infrastructure.containers;
using nothinbutdotnetstore.model;
using nothinbutdotnetstore.web.application.mappers;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application
{
    public class RequestFactoryResolver : ContainerResolver
    {
        public object resolve()
        {
            return new DefaultRequestFactory(
                new DefaultMapperRegistry(
                    new Dictionary<Type, object>()
                    {
                        {typeof(Department), new DepartmentMapper()},
                        {typeof(Product), new ProductMapper()}
                    }
                 ));
        }
    }
}