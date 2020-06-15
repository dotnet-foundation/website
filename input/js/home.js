$(document).ready(function () {

	var iconBoxes = $('.icon-box');

	function showBoxes() {
		if ($(window).scrollTop() + $(window).height() > $(iconBoxes[0]).offset().top) {
			iconBoxes.each(function () {
				var box = $(this);

				box.css({ animationName: 'zoomInUp' });
				box.find('.counter').counterUp();

				setTimeout(function () {
					box.css('opacity', '1');
					var plus = box.find('.icon-plus');

					if (plus) {
						plus.css({ display: 'inline' });
					}
				}, 500);

			});

			$(window).off('scroll', showBoxes);

			return true;
		}
		iconBoxes.each(function () {
			var box = $(this);
			var plus = box.find('.icon-plus');

			if (plus) {
				plus.css({ display: 'none' });
			}

		});
		return false;
	}

	if (!showBoxes()) {
		$(window).on('scroll', showBoxes);
	}

	$('.flash_close').on('click', function () {
		$('.flash').slideUp('fast');
	})

	var presetEvents = document.getElementById('PresetEvents');

	let eventsListItem = (event) => (
		`<div class="latest_container latest_container--event">
            <div class="latest_date d-flex align-items-center justify-content-center text-center">${event.date}</div>
            <div class="latest_meta d-flex flex-column justify-content-center">
                <h3 class="latest_title"><a href="${event.link}">${event.name}</a></h3>
                <p class="latest_copy">
                    ${event.description ? event.description : "<span>(No description listed)</span>"}
                </p>
            </div>
        </div>`
	);

	let eventsList = (list) => (
		`${list.map(eventsListItem).join('')}`
	);

	$.ajax({
		url: "https://api.meetup.com/pro/dotnet/events",
		jsonp: "callback",
		dataType: "jsonp",
		data: {
			format: "json"
		},
		success: function (response) {
			var meetups = response.data;
			var events = [];
			meetups.slice().sort((a, b) => new Date(b.event.local_date) - new Date(a.event.local_date)).reverse().slice(0, 5).map(m => {
				var html = m.chapter && m.chapter.description ? `${m.chapter.description.slice(0, 175)}${m.chapter.description.length > 175 ? '...' : ''}` : '';
				var div = document.createElement("div");
				div.innerHTML = html;
				var text = div.textContent || div.innerText || "";
				var date = new Date(m.event.time);
				const months = [
					'January',
					'February',
					'March',
					'April',
					'May',
					'June',
					'July',
					'August',
					'September',
					'October',
					'November',
					'December'
				]
				events.push({
					link: m.event.link,
					name: m.event.name,
					date: `${months[date.getMonth()]} ${date.getDate()}`,
					description: text
                })
            })
			presetEvents.innerHTML = eventsList(events);
		}
	});

	var presetFeaturedProject = document.getElementById('PresetFeaturedProject');

	let featuredProject = (title, description, link, image, alt) => (
		`
			<div class="page-section_column col-sm-7 text-left" id="home-featured-project_container">
					<h2>Featured Project</h2>
					<h3><a href="${link}">${title}</a></h3>
					<p>
							${description}
					</p>
					<h4>
							<a href="https://builtwithdot.net">More on BuiltWithDot.Net&gt;</a>
					</h4>
			</div>
			<div class="page-section_column col-sm-5">
					<img src="${image}" alt="${alt}" />
			</div>
		`
	);

  $.get("https://builtwithdot.net/feed/featured?truncateBody=false", function (data) {
		$xml = $(data);
		var featuredItem = $xml.find('item')[0];
		var title = $(featuredItem).find('title').text(),
			description = $(featuredItem).find('description').text(),
			link = $(featuredItem).find('link').text(),
			image = $(featuredItem).find('enclosure').attr('url');
		presetFeaturedProject.innerHTML = featuredProject(title, description, link, image);
	}).fail(function () {
		presetFeaturedProject.innerHTML = featuredProject("VisualStudioTips.co.uk",
			"The inspiration for this project To share the collection of Tips for Visual Studio that I have gathered and use The inspiration for this project To share the collection of Tips for Visual Studio that I have gathered and use What it does Shows how to use features of Visual Studio How you / your team built it Just me.During evenings Challenges you / your team ran into Having to come up with 4 tips at a time(or the 4 column layout would look wrong) Accomplishments that you are / your team is proud of Being mentioned by Martin Beeby at a Tech Meetup What you / your team learned People love keyboard shortcuts, some tips are better known than others What's next for this project? Keep adding more tips.Possibly add videos.",
			"https://builtwithdot.net/project/463/visualstudiotips.co.uk",
			"https://images.weserv.nl/?url=https://fluxmatix-public-assets.s3.amazonaws.com/builtwithdotnet/project%20images/tips-for-visual-studio.png",
      "Visual studio tips");
	})

});
