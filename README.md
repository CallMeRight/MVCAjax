# MVCAjax
Implementing AJAX in ASP.NET MVC
         /* 
            需安装Microsoft jQuery Unobtrusive Ajax 这个 NuGet 插件 
            Install-Package Microsoft.jQuery.Unobtrusive.Ajax
            AjaxOptions中还有其他可以指定的属性： 
            Confirm                 等效于javascript中的return confirm(msg)，在点击该链接时先提示需要确认的信息。 
            HttpMethod              指定使用Get或者是Post方式发送Http请求 
            InsertMode              指定使用何种方式在指定的元素更新数据，"InsertAfter", "InsertBefore", or "Replace" 默认为：Replace 
            LoadingElementDuration  Loading元素显示的时间 
            LoadingElementId        可以指定在Http请求期间显示的Loading元素 
            OnBegin                 在Http请求之前执行的javascript方法 
            OnComplete              在Http请求结束时执行的方法 
            OnFailure               在Http请求失败时执行的方法 
            OnSuccess               在Http请求成功时执行的方法 
            UpdateTargetId          Http请求更新的页面元素 
            Url Http请求的Url          
         */
