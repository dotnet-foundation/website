$(document).ready(function () {
	var presetEvents = document.getElementById('PresetEvents');

	let eventsListItem = (event) => (
		`<div class="latest_container latest_container--event">
            <div class="latest_date d-flex align-items-center justify-content-center text-center"><p style="color:black;">${event.date}</p></div>
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
        url: "https://api.meetup.com/dotnet-virtual-user-group/events",
		jsonp: "callback",
		dataType: "jsonp",
		data: {
			format: "json"
		},
		success: function (response) {
			var meetups = response.data;
			var events = [];
			meetups.slice().sort((a, b) => new Date(b.local_date) - new Date(a.local_date)).reverse().slice(0, 5).map(m => {
				var html =m.description ? `${m.description.slice(0, 175)}${m.description.length > 175 ? '...' : ''}` : '';
				var div = document.createElement("div");
				div.innerHTML = html;
				var text = div.textContent || div.innerText || "";
				var date = new Date(m.time);
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
					link: m.link,
					name: m.name,
					date: `${months[date.getMonth()]} ${date.getDate()}`,
					description: text
                })
            })
			presetEvents.innerHTML = eventsList(events);
		}
	});

});
