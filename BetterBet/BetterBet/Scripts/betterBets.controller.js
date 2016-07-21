(function () {
    "use strict";
    function bbmsController($scope, bbData, bbModal, bbHelp, bbmsResources, bbmsCommon, bbPalette, portalFeatureAccess, $sce) {
        

        var chatButtonPromise = bbmsCommon.isChatButtonVisible();
        chatButtonPromise.then(function (response) {
            self.chatButtonVisible = response;

            self.openChat = function () {
                if (self.chatButtonVisible) {
                    window.open(self.getText('ChatUrl'), 'popupwindow' + Math.round(Math.random() * 10000000000), 'toolbar=no,menubar=no,status=yes,scrollbars=yes,resizable=yes,width=500,height=500 top=80,left=120');
                }
                return false;
            };
        });
    }

    bbmsController.$inject = ['$scope', 'bbData', 'bbModal', 'bbHelp', 'bbmsResources', 'bbmsCommon', 'bbPalette', 'portalFeatureAccess', '$sce'];

    angular.module('bbms')
        .controller('bbmsCtrl', bbmsController);
})();
