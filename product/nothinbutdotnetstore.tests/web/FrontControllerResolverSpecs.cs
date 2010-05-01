using System;
using System.Collections.Generic;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.harnesses.mbunit;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.infrastructure.containers;
using nothinbutdotnetstore.infrastructure.containers.custom;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.tests.web
{
    public class FrontControllerResolverSpecs
    {
        public abstract class concern : observations_for_a_sut_with_a_contract<ContainerResolver,
                                            FrontControllerResolver>
        {

        }

        [Concern(typeof(FrontControllerResolver))]
        public class when_resolve_requested_type : concern
        {
            context c = () =>
            {


            };

            because b = () =>
            {
                result = (DefaultFrontController)sut.resolve();
            };


            it should_resolve_specified_object = () =>
            {
                result.should_be_an_instance_of<DefaultFrontController>();


            };

            static DefaultFrontController result;
        }
    }
}