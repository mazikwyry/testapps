class Comment < ActiveRecord::Base
  attr_accessible :author, :content, :news_id
  belongs_to :news
end
