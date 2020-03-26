$(document).ready(function () {

	var iconBoxes = $('.icon-box');

	function showBoxes() {
		if ($(window).scrollTop() + $(window).height() > $(iconBoxes[0]).offset().top + 20) {
			iconBoxes.each(function () {
				var box = $(this);

				$(this).css({ animationName: 'zoomInUp' });
				box.find('.counter').counterUp({ delay: 10, time: 2e3 });

				setTimeout(function () {
					box.css('opacity', '1');
				}, box.data('delay'));

			});

			$(window).off('scroll', showBoxes);

			return true;
		}

		return false;
	}

	if (!showBoxes()) {
		$(window).on('scroll', showBoxes);
	}

	$('.flash_close').on('click', function () {
		$('.flash').slideUp('fast');
	})

});