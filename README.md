# Umbraco ReactJs Application 

Power full the CMS on back-end and Single page application created with React Js on the front-end


## What is this?
This is the default Umbraco startekit reimagined as a badass single-page app, powered by React. It's an example of how Umbraco and React can come together beautifully.

Built with love for our Umbraco friends to show the world how easy you can transform umbraco website to SPA

## Features
* React components are rendered server-side within the Umbraco pipeline
* Content is rendered by Umbraco grid, you can edit content in the backoffice just like a regular Umbraco site
* Use of ES6 syntax & a build pipeline will be immediately familiar to React developers 
* Bundled with Webpack with 90% code re-use between server and client bundles



## Technical Overview

### [Controllers - the layer between Umbraco and ReactJs](https://github.com/dzolu/UmbracoWithReactJs/tree/master/UmbracoWithReactJs/Controllers)

Each document type in my concept has on the controller.  I'm using the concept of [Custom controllers (Hijacking Umbraco Routes)](https://our.umbraco.org/documentation/reference/routing/custom-controllers) to achieve the routing in the very neater way. 
Incoming requests are handled by a [custom DefaultController](https://github.com/dzolu/UmbracoWithReactJs/blob/master/UmbracoWithReactJs/Controllers/DefaultController.cs) extended by custom controllers. To set up custom default controller you just have to call method SetDefaultControllerType when application is starter. [Example](https://github.com/dzolu/UmbracoWithReactJs/blob/master/UmbracoWithReactJs/App_Start/UmbracoWithReactJs.cs). For more information refer to [docs](https://our.umbraco.org/documentation/implementation/default-routing/Controller-Selection/). In default controller, I'm checking the type of request. The type determines what will be returned (full markup or chunk for specific content for the page when ajax request from page). The custom controller provides the layer of abstraction and helps separate logic from the controller.  It custom controller overrides CreateInitialState method from default controller and call model adapter created for specific content. This way I have achieved server-side routing which is easy for testing and extends. As you can see rather than try to hack the routes I have used the concept which is well documented in [Umbraco documentation](https://our.umbraco.org/documentation/Reference/Routing/) 


### Model adapter 

Model adapter follows the adapter design pattern. Each model adapter implements the interface IModelAdapter<T> and contains adapt method with taking one argument of type IPublishContent. [Example](https://github.com/dzolu/UmbracoWithReactJs/blob/master/UmbracoWithReactJs/Model%20Adapter/HeroModelAdapter.cs)
Adapt method map properties from IPublishContent to model and return it. It this way I achieve a clear way of mapping Umbraco properties into the model. The model adapter is very easy to testing because is using the concept of Dependency Injection

### IOC with Umbraco

I'm using Autofac as my IOC framework. Yoy can use any other IOC framework. I have choosen Autofac because is describe in [Umbraco docs](https://our.umbraco.org/documentation/reference/using-ioc). You can add new types to Autofact [here](https://github.com/dzolu/UmbracoWithReactJs/blob/master/UmbracoWithReactJs/App_Start/UmbracoWithReactJs.cs) 



## Contributing
Happy to hear from you. The project will be extended with an example of unit testing. If you like my way of connecting the Umbraco with react join me and help improve the project.



## License
Copyright 2017 Tomasz Koszkul

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

