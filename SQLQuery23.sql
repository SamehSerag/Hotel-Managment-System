insert into Reservation
select r.first_name, r.last_name, r.birth_day, r.gender,
		r.phone_number, r.email_address, r.number_guest, r.street_address,
		r.apt_suite, r.city, r.state, r.zip_code, r.room_type, r.room_floor,
		r.room_number, r.total_bill, r.payment_type, r.card_type,
		r.card_number, r.card_exp, r.card_cvc, r.arrival_time, r.leaving_time,
		r.check_in, r.break_fast, r.lunch, r.dinner, r.cleaning, r.towel, r.s_surprise,
		r.supply_status, r.food_bill
from FRONTEND_RESERVATION.dbo.reservation r
--d