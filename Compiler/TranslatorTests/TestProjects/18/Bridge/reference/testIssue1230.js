﻿(function (globals) {
    "use strict";

    Bridge.define('TestIssue1230.Issue1230', {
        statics: {
            test: function () {
                var v = 7;
                var l = Bridge.Long(v);
                l = Bridge.Long(v);
    
                console.log(Bridge.Long(v).toString());
                console.log(Bridge.Long((v)).toString());
                console.log(Bridge.Long(2).toString());
                console.log(Bridge.Long(2).toString());
                console.log(Bridge.Long(7).toString());
                TestIssue1230.Issue1230.method(Bridge.Long(v));
                TestIssue1230.Issue1230.method(Bridge.Long(v));
            },
            method: function (l) {
            }
        }
    });
    
    
    
    Bridge.init();
})(this);
