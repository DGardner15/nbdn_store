 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.harnesses.mbunit;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.infrastructure.containers;
 using nothinbutdotnetstore.web.application;

namespace nothinbutdotnetstore.tests.web
 {   
     public class RequestFactoryResolverSpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<ContainerResolver,
                                             RequestFactoryResolver>
         {
        
         }

         [Concern(typeof(RequestFactoryResolver))]
         public class when_ask_to_resolver_request_factory : concern
         {
             context c = () =>
             {
            
             };

             because b = () =>
             {
                 result = (RequestFactoryResolver) sut.resolve();
        
             };

        
             it should_return_default_request_factory = () =>
             {
                 result.should_be_an_instance_of<RequestFactoryResolver>();
            
            
             };

             static RequestFactoryResolver result;
         }
     }
 }
