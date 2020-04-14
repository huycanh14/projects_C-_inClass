var app = angular.module('myApp', ['ngMaterial']);
app.controller('MyController',  function ($scope, $http, $mdToast) {

	$scope.hienradi = function(motnguoi){
		motnguoi.hienra = !motnguoi.hienra;
	}
	$http.get("http://phpfedu.demo/aungular_php1/welcome/laydulieu")
	.then(function(response) {
		//console.log(response.data);
		$scope.nhieunguoi = response.data;
	});

	$scope.luudulieu = function(nguoi){
		//thay đổi front-end
		nguoi.hienra = !nguoi.hienra;
		//sử dụng hàm post để hết nối đến sql
		var data = $.param({
			id:nguoi.id,
			facebook:nguoi.facebook,
			sodienthoai:nguoi.sodienthoai,
			namsinh:nguoi.namsinh,
			ten:nguoi.ten
		});
		var config = {
			headers: {
				'content-type': 'application/x-www-form-urlencoded; charset=utf-8'
			}
		}
		$http.post('http://phpfedu.demo/aungular_php1/welcome/luudulieu', data, config)
		.then(function(res){ //thành công
			if(res.data == 'thanhcong'){
				console.log('Cập nhật thành công');
				$scope.showSimpleToast();
			}
		}, function(res){//thất bại
			if(res.data == 'thatbai')
				console.log('Cập nhật thất bại');
		});
	}

	//Hiển thị thông báo
	var last = {
		bottom: false,
		top: false,
		left: false,
		right: true
	};

	$scope.toastPosition = angular.extend({}, last);

	$scope.getToastPosition = function() {
		sanitizePosition();

		return Object.keys($scope.toastPosition)
		.filter(function(pos) {
			return $scope.toastPosition[pos];
		}).join(' ');
	};

	function sanitizePosition() {
		var current = $scope.toastPosition;

		if (current.bottom && last.top) {
			current.top = false;
		}
		if (current.top && last.bottom) {
			current.bottom = false;
		}
		if (current.right && last.left) {
			current.left = false;
		}
		if (current.left && last.right) {
			current.right = false;
		}

		last = angular.extend({}, current);
	}

	$scope.showSimpleToast = function() {
		var pinTo = $scope.getToastPosition();

		$mdToast.show(
			$mdToast.simple()
			.textContent('Cập nhật thành công')
			.position(pinTo)
			.hideDelay(3000)
		);
	};
	//Kết thúc hiển thị thông báo
});
/*.controller('AppCtrl', AppCtrl);

  function AppCtrl($mdToast, $log) {
    var ctrl = this;
    var last = {
      bottom: false,
      top: false,
      left: false,
      right: true
    };

    ctrl.toastPosition = angular.extend({}, last);

    ctrl.getToastPosition = function() {
      sanitizePosition();

      return Object.keys(ctrl.toastPosition)
      .filter(function(pos) {
        return ctrl.toastPosition[pos];
      }).join(' ');
    };

    function sanitizePosition() {
      var current = ctrl.toastPosition;

      if (current.bottom && last.top) {
        current.top = false;
      }
      if (current.top && last.bottom) {
        current.bottom = false;
      }
      if (current.right && last.left) {
        current.left = false;
      }
      if (current.left && last.right) {
        current.right = false;
      }

      last = angular.extend({}, current);
    }

    ctrl.showSimpleToast = function() {
      var pinTo = ctrl.getToastPosition();

      $mdToast.show(
        $mdToast.simple()
        .textContent('Simple Toast!')
        .position(pinTo)
        .hideDelay(3000))
      .then(function() {
        $log.log('Toast dismissed.');
      }).catch(function() {
        $log.log('Toast failed or was forced to close early by another toast.');
      });
    };
  }
})();*/