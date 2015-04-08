var arraySource = {
    Id: 1,
    ProvidersDomains: [{
        Id: 11,
        Name: 'Name 11'
    }],
    Prop2: 1
};

var provDomains = function (data) {
    var self = this;
    ko.mapping.fromJS(data, {}, self);
}
var mapping = {
    key: function (item) {
        return ko.utils.unwrapObservable(item.Id);
    },
    'ProvidersDomains': {
        key: function (Domain) {
            return ko.utils.unwrapObservable(Domain.Id);
        },
        create: function (options) {
            return new provDomains(options.data);
        }
    }
};
var model = function () {
    var self = this;
    self.NewDomain = ko.observable("");
    self.NewId = ko.observable("");
    self.FromSubscribe = ko.observable("");
    self.ProvidersDomains = ko.observableArray([]);
    self.ProvidersDomains.subscribe(function (data) {
        //console.log('from subscribe');
        //debugger;
        //console.log(data[data.length - 1].Id());
        self.FromSubscribe("Id: " + data[data.length - 1].Name() + "/Name: " + data[data.length - 1].Id());
    });

    self.mappingEv = function () {
        ko.mapping.fromJS(arraySource, mapping, self);
    };
    self.addEv = function () {
        self.ProvidersDomains.push(new provDomains({
            Id: self.NewId(),
            Name: self.NewDomain()
        }));


    }
}
var obj = new model();
ko.applyBindings(obj);